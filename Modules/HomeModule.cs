using Carter;
using Microsoft.AspNetCore.Http;

namespace bookshelf.Modules {
  public class HomeModule : CarterModule {
    public HomeModule() {
      Get("/", async (req, res) => await res.WriteAsync("hello, world!"));
    }
  }
}
