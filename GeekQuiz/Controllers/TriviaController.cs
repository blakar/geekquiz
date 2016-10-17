namespace GeekQuiz.Controllers
{
    using GeekQuiz.Models;
    using System.Web.Http;

    public class TriviaController : ApiController
    {
        private TriviaContext db = new TriviaContext();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
