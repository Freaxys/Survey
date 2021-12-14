﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SurveyAppEntities : DbContext
    {
        public SurveyAppEntities()
            : base("name=SurveyAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AllAnswers> AllAnswers1 { get; set; }
        public virtual DbSet<AnswerSet> AnswerSets { get; set; }
        public virtual DbSet<QuestionSet> QuestionSets { get; set; }
    
        [DbFunction("SurveyAppEntities", "GetQuestions")]
        public virtual IQueryable<string> GetQuestions(Nullable<int> param1)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<string>("[SurveyAppEntities].[GetQuestions](@param1)", param1Parameter);
        }
    
        public virtual int SaveForm(string scale, string yesOrNo, string comment)
        {
            var scaleParameter = scale != null ?
                new ObjectParameter("scale", scale) :
                new ObjectParameter("scale", typeof(string));
    
            var yesOrNoParameter = yesOrNo != null ?
                new ObjectParameter("yesOrNo", yesOrNo) :
                new ObjectParameter("yesOrNo", typeof(string));
    
            var commentParameter = comment != null ?
                new ObjectParameter("comment", comment) :
                new ObjectParameter("comment", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SaveForm", scaleParameter, yesOrNoParameter, commentParameter);
        }
    }
}
