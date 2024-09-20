using APBDProject.Models;
using APBDProject.Repositories;
using APBDProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBDProject.Controllers;

public class SongsController : Controller
{
    private ISongsService _songsService;
    
    public SongsController(ISongsService songsService)
    {
        _songsService=songsService;
    }
    
    
    // GET
    public async Task<IActionResult> Index(string query, CancellationToken cancellationToken)
    {
        return View(await _songsService.GetSong(query, cancellationToken));
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    // [HttpPost]
    // public IActionResult Create(Song newStudent)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         songs.Add(newStudent);
    //         return RedirectToAction("Index");
    //     }
    //     
    //     return View(newStudent);
    // }
}