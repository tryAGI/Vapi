
#nullable enable

namespace Vapi
{
    public partial interface IKnowledgeBasesV2Client
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}