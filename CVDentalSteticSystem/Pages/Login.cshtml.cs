using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using CVDentalSteticSystem.BLL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Routing;

namespace CVDentalSteticSystem.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        public string ReturnUrl { get; set; }
        public BlazoredToasts toast { get; set; }

        public async Task<IActionResult> OnGetAsync(string Usuario, string Contrasena)
        {
            string returnUrl = Url.Content("~/");
            try
            {
                // Clear the existing external cookie
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch { }
            // *** !!! This is where you would validate the user !!! ***
            // In this example we just log the user in
            // (Always log the user in for this demo)

           if (UsuariosBLL.ConfirmacionUsuario(Usuario, Contrasena))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Usuario),
                    new Claim(ClaimTypes.Role, UsuariosBLL.GetNivel(Usuario))

                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };

                try
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }
            

            return LocalRedirect(returnUrl);
        }
    }
}