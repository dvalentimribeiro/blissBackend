using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Bliss.Models;
using Bliss.DtoModels;
using BlissRecruitment.Models;

namespace Bliss.Controllers
{
    public class QuestionsController : ApiController
    {
        private BlissRecruitmentContext db = new BlissRecruitmentContext();



        // GET: api/Questions?limit={value}&offset={value}&filter={filter}
        /// Questions all questions tha match with question property or choices properties 
        [ResponseType(typeof(Question))]

        public IHttpActionResult GetQuestionByPage([FromUri] DtoQuestionSearchByPage dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IQueryable<Question> questions = db.Questions;

            var hasFilter = dto.filter != null;

            if (hasFilter)
            {

                var filter = dto.filter.Trim().ToLower();
                questions = db.Questions.Where(q => q.question.Contains(filter) ||
                q.Choices.Any(c => c.choice.Contains(filter) || c.votes.ToString().Contains(filter)));
            }

            //Pagining
            questions = questions.OrderBy(q => q.id).Skip(dto.offset).Take(dto.limit);


            return Ok(questions);
        }

        //GET: api/Questions/question_id
        [ResponseType(typeof(Question))]
        [Route("api/questions/{id}")]
        public IHttpActionResult GetQuestionById(int id)
        {
            Question question = db.Questions.Find(id);
            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }



        // POST: api/Questions
        [ResponseType(typeof(Question))]
        public IHttpActionResult PostQuestion(Question question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            question = db.Questions.Add(question);
            db.SaveChanges();

            return Ok(question);
        }

        // PUT: api/Questions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuestion(int question_id, [FromBody] Question question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entry(question).State = EntityState.Modified;
            db.SaveChanges();

            return Ok(HttpStatusCode.NoContent);
        }
    }
}