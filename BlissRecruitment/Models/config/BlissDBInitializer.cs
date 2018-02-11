using Bliss.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlissRecruitment.Models.config
{
    public class BlissDBInitializer : CreateDatabaseIfNotExists<BlissRecruitmentContext>
    {
        protected override void Seed(BlissRecruitmentContext context)
        {

            for (int i = 0; i < 100; i++)
            {
                context.Questions.Add(new Question { question = "teste", Choices = new List<Choice>() }); ;
            }


            foreach (var question in context.Questions)
            {
                for (int i = 0; i < 10; i++)
                {
                    question.Choices.Add(new Choice { choice = "Opção 1", votes = i });
                }

            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}