﻿using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CoffeeShopController : ControllerBase
{
    private readonly ICoffeeShopService _coffeeShopService;

    public CoffeeShopController(ICoffeeShopService coffeeShopService)
    {
        _coffeeShopService = coffeeShopService;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var coffeeShops = await _coffeeShopService.List();
        return Ok(coffeeShops);
    }
}