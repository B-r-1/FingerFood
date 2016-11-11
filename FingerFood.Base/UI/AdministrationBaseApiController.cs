//using AutoMapper;
//using Mvz.Fwk.CustomAttributes;
//using Mvz.Fwk.Domain.Entities;
//using Mvz.Fwk.Domain.IRepositories;
//using Mvz.Fwk.Domain.Views;
//using Mvz.Fwk.Utils;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mvz.Fwk.UI {
//    public class AdministrationBaseApiController<R, E, D> : BaseApiController<R, E>
//        where R : IRepository<E>
//        where E : EntityBase
//        where D : ViewBase {

//        public AdministrationBaseApiController(R repository)
//            : base(repository) { }
//        public virtual D Get(Int64 id) {
//            var item = base.Repository.Get().Where(x => x.Id == id).FirstOrDefault();
//            return Mapper.Map<E, D>(item);
//        }

//        public virtual HttpResponseMessage Post(E entity) {
//            if (ModelState.IsValid) {
//                base.SetUserContext(entity);

//                if (entity.Id == 0) {
//                    this.Repository.Save(entity);
//                    if (this.MoveFileToSave(entity)) {
//                        this.Repository.Save(entity);
//                    }
//                }
//                else {
//                    this.Repository.Save(entity);
//                    if (this.MoveFileToSave(entity)) {
//                        this.Repository.Save(entity);
//                    }
//                }
//                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, entity);
//                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.Id }));
//                return response;
//            }
//            else {
//                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
//            }
//        }

//        private Boolean MoveFileToSave(E entity) {

//            var move = false;

//            // Get properties from main Entity.
//            var props = from p in entity.GetType().GetProperties()
//                        let attr = p.GetCustomAttributes(typeof(FilePathAttribute), true)
//                        where attr.Length == 1
//                        select new { Property = p, Attribute = attr.First() as FilePathAttribute };

//            foreach (var item in props) {
//                var path = item.Property.GetValue(entity);
//                if (path != null) {
//                    if (entity.Status != 0) {
//                        move = true;
//                        item.Property.SetValue(entity, base.MoveFromTemporalPath(base.DirectoryPath, path.ToString(), entity.Id, entity.GetType().Name));
//                    }
//                    else {
//                        base.DeleteFile(base.DirectoryPath, path.ToString());
//                    }
//                }
//            }

//            // Get properties from each collection
//            foreach (var collection in ReflectionHelper.GetCollections<E>(entity)) {

//                Type childEntityType = null;
//                dynamic childProperties = null;
//                foreach (var point in collection) {
//                    var childEntity = point as EntityBase;
//                    if (childEntityType == null) {
//                        childEntityType = childEntity.GetType();

//                        childProperties = from p in childEntity.GetType().GetProperties()
//                                          let attr = p.GetCustomAttributes(typeof(FilePathAttribute), true)
//                                          where attr.Length == 1
//                                          select new { Property = p, Attribute = attr.First() as FilePathAttribute };
//                    }

//                    foreach (var item in childProperties) {
//                        var path = item.Property.GetValue(childEntity);
//                        if (path != null) {
//                            if (childEntity.Status != 0) {
//                                move = true;
//                                item.Property.SetValue(childEntity, this.MoveFromTemporalPath(base.DirectoryPath, path.ToString(),
//                                                                                              childEntity.Id, childEntityType.Name));
//                            }
//                            else {
//                                base.DeleteFile(base.DirectoryPath, (String)path);
//                            }
//                        }
//                    }
//                }
//            }
//            return move;

//        }
//    }
//}
