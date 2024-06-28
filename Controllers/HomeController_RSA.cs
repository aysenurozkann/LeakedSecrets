using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppDBA.Models;

namespace WebAppDBA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

-----BEGIN RSA PRIVATE KEY-----
MIICXAIBAAKBgGsCD1X4vLu9nLD4+xBUSzqdJJbUJMp2aIMDFvpCRAzKhLK0P19C
vN2kdvY7qFDCGE80LpNRmzkx5gUwOJyMv45tNzp666bkXr4Ndlz14CbgaVVqyV9t
2zCxlDLWvpinUa4Nf3ovv6mHsicM1M+y41/qr1g9Ay6BlMkbswhXg5zhAgMBAAEC
gYADQybQiirG1nsGcjDFSKyadtv8tS8B9SYuiFOVAZwtf6cYA6LC9rfnUfJGg38Y
JzKyh3a8CwrebYUDt3qiWzAjzwtXhJE9xyK19zsd1vFiAO9znMjcOL6RcscaQEZW
dg6KXYpOfDG4b7BVtnAkfjY1Q9PQxdmNgGVT+aLo5ZFGGQJBANSzq6FQGEG12999
FnaMST7u/c/NqSVGLl23OSAZLUJKeSsR5tWJFEEaWk2E2Gp83HE9r6rcHYvIuNjM
4E3zETsCQQCAyngOCvwCLkB9RkV2+IRprw+RL1jM9yFrHKbEJv2qmfzBB1N6/Ng7
/NdpOpPPW4/FKErS8ZeAU1G9RrJaxqiTAkEAt03LyG49KUvvm6+yTyHg8bKG27Hy
ZiQQS0VenrHz1iBWQe7gjv/ei6iJUCr/Uu4eEB1IKageclveKUCOwb6LBwJALRKu
4XtGpxy4xR8KwJBJBxOVRyJi2ZjDwVDNrGhY7pPluUhvFuPWaWgbm2A8yp0ou79W
MG0MsIR4Xt2XHd3YsQJBAJvlbiqzKcRw/PASg1XS3IQ5bt9g5D34T5rJo0LcSt0z
JbcA39bJ8Xm/maywe7eCfdiy3tivLLILDUWfhKBKB8Q=
-----END RSA PRIVATE KEY-----

-----BEGIN PUBLIC KEY-----
MIGeMA0GCSqGSIb3DQEBAQUAA4GMADCBiAKBgGsCD1X4vLu9nLD4+xBUSzqdJJbU
JMp2aIMDFvpCRAzKhLK0P19CvN2kdvY7qFDCGE80LpNRmzkx5gUwOJyMv45tNzp6
66bkXr4Ndlz14CbgaVVqyV9t2zCxlDLWvpinUa4Nf3ovv6mHsicM1M+y41/qr1g9
Ay6BlMkbswhXg5zhAgMBAAE=
-----END PUBLIC KEY-----