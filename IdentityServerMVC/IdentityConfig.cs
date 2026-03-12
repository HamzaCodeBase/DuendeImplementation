using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;

namespace IdentityServer
{
    public static class IdentityConfig
    {
        internal static IEnumerable<Client> Clients => new List<Client>
        {
            new Client
            {
                ClientId = "blazor-client",
                AllowedGrantTypes = GrantTypes.Code,
                RequireClientSecret = false,
                RedirectUris = { "https://localhost:7001/authentication/login-callback" },
                PostLogoutRedirectUris = { "https://localhost:7001/" },
                AllowedScopes = { "openid", "profile", "api1" },
                RequirePkce = true,
                AllowedCorsOrigins = { "https://localhost:7001" }
            }
        };

        internal static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new ApiScope("api1", "Access to Protected API")
        };

        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

        public static List<TestUser> TestUsers => new List<TestUser>
        {
            new TestUser { SubjectId = "1", Username = "test@gmail.com", Password = "Test-123" }
        };
    }
}
