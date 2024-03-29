﻿using System.Collections.Generic;
using GraphColoring.Application.Dtos.Algorithms.Responses;
using GraphColoring.Application.Dtos.Graphs;
using System.Threading.Tasks;

namespace GraphColoring.Application.Interfaces.Services
{
    public interface IAlgorithmService
    {
        Task<AlgorithmResponse> PerformGreedyAlgorithm(int graphId);

        Task<AlgorithmResponse> PerformLargestFirstAlgorithm(int graphId);
        Task<AlgorithmResponse> PerformLowestFirstAlgorithm(int graphId);

        Task<AlgorithmResponse> PerformABCAlgorithm(int graphId, int employeeBeesSize, int employeeBeesNeighborSize, int onLookerBeesSize, 
            int onLookerBeesNeighborSize, int scoutBeesSize, int maxCycles, int onLookerBeesFavouredSolutionsNumber);

        Task<AlgorithmResponse> PerformSimulatedAnnealing(int graphId, int coolingParameter, int maxCycles, int neighbourhoodLookupNumber);

        Task<List<float>> GetGraphInfo(int graphId);

        Task Work();

    }
}
