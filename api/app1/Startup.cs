using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependecyInjection;
using TodoApi.Models;

namespace app1
{
    public class Startup
    {
		public void ConfigureServices(IServiceCollection services){
			services.AddDbContext<TodoContext>(opt => opt.UserInMemoryDatabase("TodoList"));
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}
		
		public void Configure(IApplicationBuilder app){
			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseMvc();
		}
    }
}
