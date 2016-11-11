using FingerFood.Base.Domain;
using FingerFood.Base.Domain.Entities;
using FingerFood.Base.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
//using Microsoft.AspNet.Identity;
//using FingerFood.Base.ExtensionMethods;
//using FingerFood.Base.Criterias;
using FingerFood.Base.Utils;

namespace FingerFood.Base.UI
{

	//TODO: Security
	[Authorize]
	public class BaseApiController<R, E> : ApiController
		where R : IRepository<E>
		where E : EntityBase {

        //protected Int64 CurrentUserId {
        //    get {
        //        //TODO: Security
        //        //return 17; 
        //        //return User.Identity.GetUserId<Int64>();
        //    }
        //}

		public R Repository { get; set; }

		public BaseApiController(R repository) {
			this.Repository = repository;
		}

        //protected void SetUserContext(E entity) {
        //    FingerFood.Base.Domain.IUser user = entity as FingerFood.Base.Domain.IUser;
        //    if (user != null) {
        //        user.UserId = this.CurrentUserId;
        //    }

        //    // Set user ID for each child items
        //    foreach (var collection in ReflectionHelper.GetCollections<E>(entity)) {
        //        if (collection != null) {
        //            foreach (var point in collection) {
        //                var childEntity = point as EntityBase;

        //                //user = childEntity as FingerFood.Base.Domain.IUser;
        //                //if (user != null) {
        //                //    user.UserId = this.CurrentUserId;
        //                }
        //            }
        //        }
        //    }
        //}

		public HttpResponseMessage Delete(Int64 id) {
			var entity = this.Repository.Get().Where(x => x.Id == id).FirstOrDefault();
			if (entity != null) {
				entity.Status = 0;
				this.Repository.Save(entity);
				return Request.CreateResponse(HttpStatusCode.OK, entity);
			}
			return Request.CreateResponse(HttpStatusCode.NotFound);
		}

		#region File Manager

		private String assemblyPath = null;
		protected String AssemblyPath {
			get {
				if (String.IsNullOrEmpty(assemblyPath)) {
					assemblyPath = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
				}
				return assemblyPath;
			}
		}

		private String directoryPath = null;
		protected String DirectoryPath {
			get {
				if (String.IsNullOrEmpty(directoryPath)) {
					directoryPath = Path.GetDirectoryName(this.AssemblyPath);
				}
				return directoryPath;
			}
		}

		protected void DeleteFile(String directoryPath, String filePath) {
			directoryPath = directoryPath.Replace("bin", "");
			if (filePath.StartsWith(@"\")) {
				filePath = filePath.Substring(1);
			}
			var pathSource = Path.Combine(directoryPath, filePath);
			var pathDestination = Path.Combine(directoryPath, filePath);
			String folder = Path.GetDirectoryName(pathDestination);

			if (File.Exists(pathDestination)) {
				File.Delete(pathDestination);
			}
			if (Directory.Exists(folder)) {
				Directory.Delete(folder);
			}
		}

		protected string MoveFromTemporalPath(String directoryPath, String filePath, Int64 entityID, string entityName) {
			//Move from temporal folder
			try {
				directoryPath = directoryPath.Replace("bin", "");

				if (filePath.StartsWith(@"\")) {
					filePath = filePath.Substring(1);
				}

				var pathSource = Path.Combine(directoryPath, filePath);

				filePath = filePath.Replace("Temp", entityName + "/" + entityID.ToString());
				var pathDestination = Path.Combine(directoryPath, filePath);

				var nameDestinationPath = Path.GetDirectoryName(pathDestination);
				if (!Directory.Exists(nameDestinationPath)) {
					Directory.CreateDirectory(nameDestinationPath);
				}
				if (pathSource != pathDestination) {
					if (File.Exists(pathDestination)) {
						File.Delete(pathDestination);
					}
				}
				if (pathSource != pathDestination && File.Exists(pathSource)) {
					File.Move(pathSource, pathDestination);
				}
				return filePath.Replace("Temp", entityName + "/" + entityID.ToString()).Replace(@"\", "/");
			}
			catch (Exception e) {
				Console.WriteLine("The process failed: {0}", e.ToString());
				return String.Empty;
			}
		}

		protected string MoveFromTemporalPath(String directoryPath, String filePath, Int64 entityID, String entityName, Int64 masterID, String masterName) {
			//Move from temporal folder
			try {
				directoryPath = directoryPath.Replace("bin", "");

				if (filePath.StartsWith(@"\")) {
					filePath = filePath.Substring(1);
				}

				var pathSource = Path.Combine(directoryPath, filePath);
				var pathDestination = pathSource.Replace("Temp", masterName + "/" + masterID.ToString() + "/" + entityName + "/" + entityID.ToString());
				var nameDestinationPath = Path.GetDirectoryName(pathDestination);
				if (!Directory.Exists(nameDestinationPath)) {
					Directory.CreateDirectory(nameDestinationPath);
				}
				File.Move(pathSource, pathDestination);
				return filePath.Replace("Temp", masterName + "/" + masterID.ToString() + "/" + entityName + "/" + entityID.ToString()).Replace(@"\", "/");
			}
			catch (Exception e) {
				Console.WriteLine("The process failed: {0}", e.ToString());
				return String.Empty;
			}
		}
		#endregion

		#region OrderBy

        //public IQueryable<T> ApplyBaseQuery<T>(IQueryable<T> query, ListViewCriteriaBase criteria, String name) {
        //    if (!String.IsNullOrEmpty(criteria.OrderBy)) {
        //        query = query.OrderBy(criteria.OrderBy.ToPascalCase().Replace(":", " "));
        //    }
        //    else {
        //        query = query.OrderBy(name + " ASC");
        //    }
        //    if (criteria.Size > 0) {
        //        query = query.Skip(criteria.Page * criteria.Size).Take(criteria.Size);
        //    }
        //    return query;
        //}

		#endregion
	}
}
