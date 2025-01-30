using MediatorStryker;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;

builder
    .ConfigureServices()
    .Build()
    .Configure(env)
    .Run();