﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Surveyapp.Models
{
    public class Question
    {
        public Question()
        {
            SurveyResponses = new HashSet<SurveyResponse>();
        }
        public int Id { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public int ResponseTypeId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string question { get; set; }
        [ForeignKey("SubjectId")]
        public virtual SurveySubject Subject { get; set; }
        [ForeignKey("ResponseTypeId")]
        public virtual ResponseType ResponseType { get; set; }
        public virtual ICollection<SurveyResponse> SurveyResponses { get; set; }
    }
}
