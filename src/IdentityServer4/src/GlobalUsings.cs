/*
 Copyright (c) 2024 Iamshen . All rights reserved.

 Copyright (c) 2024 HigginsSoft, Alexander Higgins - https://github.com/alexhiggins732/ 

 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code and license this software can be found 

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.
*/

global using IdentityModel;
global using IdentityServer4;
global using IdentityServer4.Configuration;
global using IdentityServer4.Configuration.DependencyInjection;
global using IdentityServer4.Endpoints;
global using IdentityServer4.Endpoints.Results;
global using IdentityServer4.Events;
global using IdentityServer4.Extensions;
global using IdentityServer4.Hosting;
global using IdentityServer4.Hosting.FederatedSignOut;
global using IdentityServer4.Hosting.LocalApiAuthentication;
global using IdentityServer4.Infrastructure;
global using IdentityServer4.Logging;
global using IdentityServer4.Logging.Models;
global using IdentityServer4.Models;
global using IdentityServer4.ResponseHandling;
global using IdentityServer4.Services;
global using IdentityServer4.Services.Default;
global using IdentityServer4.Stores;
global using IdentityServer4.Stores.Serialization;
global using IdentityServer4.Test;
global using IdentityServer4.Validation;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.Cookies;
global using Microsoft.AspNetCore.Authentication.OpenIdConnect;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Cors.Infrastructure;
//global using Microsoft.AspNetCore.DataProtection;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.WebUtilities;
global using Microsoft.Extensions.Caching.Distributed;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.Extensions.Primitives;
//global using Microsoft.IdentityModel.Tokens;
//global using Microsoft.Net.Http.Headers;
global using Newtonsoft.Json;
global using Newtonsoft.Json.Linq;
global using System.Buffers;
global using System.Collections.Concurrent;
global using System.Collections.Specialized;
global using System.Diagnostics;
global using System.Globalization;
global using System.IdentityModel.Tokens.Jwt;
global using System.Net;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Security.Claims;
global using System.Security.Cryptography;
global using System.Security.Cryptography.X509Certificates;
global using System.Security.Principal;
global using System.Text;
global using System.Text.Encodings.Web;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using static IdentityServer4.Constants;
global using static IdentityServer4.IdentityServerConstants;
global using ClaimValueTypes = System.Security.Claims.ClaimValueTypes;
