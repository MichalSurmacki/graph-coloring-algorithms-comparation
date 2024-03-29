﻿using GraphColoring.Application.Dtos.Algorithms.Requests;
using GraphColoring.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphColoring.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;

        public AlgorithmsController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }

        [HttpGet]
        [Route("Info")]
        public async Task<IActionResult> GetGraphInfo([FromQuery] int graphId)
        {
            var response = await _algorithmService.GetGraphInfo(graphId);
            return Ok(response);
        }
        
        [HttpGet]
        [Route("Work")]
        public async Task<IActionResult> Work()
        {
            await _algorithmService.Work();
            return Ok();
        }
        
        [HttpGet]
        [Route("Greedy")]
        public async Task<IActionResult> PerformGreedyAlgorithm([FromQuery] int graphId)
        {
            var response = await _algorithmService.PerformGreedyAlgorithm(graphId);
            return Ok(response);
        }
        
        [HttpGet]
        [Route("LowestFirst")]
        public async Task<IActionResult> StartLowestFirstAlgorithm([FromQuery] int graphId)
        {
            var response = await _algorithmService.PerformLowestFirstAlgorithm(graphId);
            return Ok(response);
        }

        [HttpGet]
        [Route("ABC")]
        public async Task<IActionResult> StartABCAlgorithm([FromQuery] int graphId, [FromQuery] int employeeBeesSize, [FromQuery] int employeeBeesNeighborSize,
            [FromQuery] int onLookerBeesSize, [FromQuery] int onLookerBeesNeighborSize, [FromQuery] int scoutBeesSize, [FromQuery] int maxCicles, 
            [FromQuery] int onLookerBeesFavouredSolutionsNumber)
        {
            var response = await _algorithmService.PerformABCAlgorithm(graphId, employeeBeesSize, employeeBeesNeighborSize, onLookerBeesSize,
                onLookerBeesNeighborSize, scoutBeesSize, maxCicles, onLookerBeesFavouredSolutionsNumber);
            return Ok(response);
        }

        [HttpGet]
        [Route("LargestFirst")]
        public async Task<IActionResult> StartLargestFirstAlgorithm([FromQuery] int graphId)
        {
            var response = await _algorithmService.PerformLargestFirstAlgorithm(graphId);
            return Ok(response);
        }
        
        [HttpGet]
        [Route("SimulatedAnnealing")]
        public async Task<IActionResult> StartSimulatedAnnealingAlgorithm([FromQuery] int graphId, [FromQuery] int coolingParameter, 
            [FromQuery] int maxCycles, [FromQuery] int neighbourhoodLookupNumber)
        {
            var response = await _algorithmService.PerformSimulatedAnnealing(graphId, coolingParameter, maxCycles, neighbourhoodLookupNumber);
            return Ok(response);
        }
    }
}
