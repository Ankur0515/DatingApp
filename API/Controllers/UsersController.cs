using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/[UsersController]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;


    public UsersController(DataContext context)
    {
        _context = context;

    }

}
