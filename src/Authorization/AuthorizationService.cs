/*
 * IAuthorizationService.cs
 *
 *   Created: 2022-12-16-05:39:52
 *   Modified: 2022-12-16-05:39:53
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace JustinWritesCode.Identity.Authorization;

using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

public class AuthorizationService : Microsoft.AspNetCore.Authorization.DefaultAuthorizationService
{
    public AuthorizationService(IAuthorizationPolicyProvider policyProvider, IAuthorizationHandlerProvider handlers, ILogger<DefaultAuthorizationService> logger, IAuthorizationHandlerContextFactory contextFactory, IAuthorizationEvaluator evaluator, IOptions<AuthorizationOptions> options)
        : base(policyProvider, handlers, logger, contextFactory, evaluator, options)
    {
    }

    public override Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object? resource, IEnumerable<IAuthorizationRequirement> requirements) => base.AuthorizeAsync(user, resource, requirements);

    public override Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object? resource, string policyName) => base.AuthorizeAsync(user, resource, policyName);
}

public class AuthorizationHandler : IAuthorizationHandler
{
    public Task HandleAsync(AuthorizationHandlerContext context) => throw new NotImplementedException();
}
