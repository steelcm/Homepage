using steelcm.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace steelcm.Controllers
{
    public class ProjectsAPIController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ProjectModel> Get()
        {
            var jsonModel = new List<ProjectModel>() { 
                new ProjectModel(){
                    Id = 1,
                    Name = "Portal",
                    Duration = 7,
                    Completion = new DateTime(2013, 12, 1),
                    Description = "Cloud based administration tool built to allow simple and secure maintenance of complex financial data by both internal users and external partners.",
                    Tags = TagDictionary.Where(o => (new List<TagEnum>(){TagEnum.KnockoutJS, TagEnum.MVC, TagEnum.WCF, TagEnum.SQL, TagEnum.AzureSQL}).Contains(o.Key)).ToDictionary(o => o.Key, o => o.Value)
                },
                new ProjectModel(){
                    Id = 2,
                    Name = "Polar",
                    Duration = 5,
                    Completion = new DateTime(2014, 1, 1),
                    Description = "Cloud based multi-tenant application allowing clients to access their managed financial plans as well as add their own un-managed plans.",
                    Tags = TagDictionary.Where(o => (new List<TagEnum>(){TagEnum.MVC, TagEnum.MSSQL, TagEnum.IIS }).Contains(o.Key)).ToDictionary(o => o.Key, o => o.Value)
                },
                new ProjectModel(){
                    Id = 2,
                    Name = "Polar",
                    Duration = 5,
                    Completion = new DateTime(2014, 1, 1),
                    Description = "Cloud based multi-tenant application allowing clients to access their managed financial plans as well as add their own un-managed plans.",
                    Tags = TagDictionary.Where(o => (new List<TagEnum>(){TagEnum.MVC, TagEnum.MSSQL, TagEnum.IIS }).Contains(o.Key)).ToDictionary(o => o.Key, o => o.Value)
                },
                new ProjectModel(){
                    Id = 2,
                    Name = "Polar",
                    Duration = 5,
                    Completion = new DateTime(2014, 1, 1),
                    Description = "Cloud based multi-tenant application allowing clients to access their managed financial plans as well as add their own un-managed plans.",
                    Tags = TagDictionary.Where(o => (new List<TagEnum>(){TagEnum.MVC, TagEnum.MSSQL, TagEnum.IIS }).Contains(o.Key)).ToDictionary(o => o.Key, o => o.Value)
                }
            };
            return jsonModel;
        }

        private IDictionary<TagEnum, String> TagDictionary = new Dictionary<TagEnum, String>(){
            {TagEnum.KnockoutJS, "Knockout JS"},
            {TagEnum.MVC, "ASP.Net MVC"},
            {TagEnum.WCF, "WCF"},
            {TagEnum.SQL, "Transact SQL"},
            {TagEnum.AzureSQL, "SQL Azure"},
            {TagEnum.MSSQL, "MS SQL"},
            {TagEnum.IIS, "IIS"},
            {TagEnum.AZURE, "Azure"},
        };
    }

    public enum TagEnum{
        KnockoutJS,
        MVC,
        WCF,
        SQL,
        AzureSQL, 
        MSSQL,
        IIS,
        AZURE
    }
}