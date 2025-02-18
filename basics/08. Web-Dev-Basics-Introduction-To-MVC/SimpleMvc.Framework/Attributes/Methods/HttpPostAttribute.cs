﻿namespace SimpleMvc.Framework.Attributes.Methods
{
    public class HttpPostAttribute : HttpMethodAttribute
    {
        public override bool IsValid(string requestMethod)
        {
            if (requestMethod.ToUpper().Equals("POST"))
            {
                return true;
            }

            return false;
        }
    }
}
