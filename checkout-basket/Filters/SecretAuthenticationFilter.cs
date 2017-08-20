namespace checkout_basket.Filters
{
    using CheckoutModels.Interfaces;
    using System.Configuration;
    using System.Web.Http;
    using System.Web.Http.Controllers;
    using System.Web.Http.Filters;
    using System.Linq;

    /// <summary>
    /// Basic auth using the secret key from the test app.
    /// </summary>
    public class SecretAuthenticationFilter : ActionFilterAttribute
    {
        /// <summary>
        /// Attrib used on all actions.
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            bool success = false;

            if (actionContext.Request != null && actionContext.Request.Headers.Contains("authorization"))
            {
                var value = actionContext.Request.Headers.GetValues("authorization");
                var secret = ConfigurationManager.AppSettings["AuthSecret"];

                if (value.FirstOrDefault() == secret)
                {
                    success = true;
                }
            }

            if (!success)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                return;
            }
        }
    }
}