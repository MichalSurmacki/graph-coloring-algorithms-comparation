﻿using System.Collections.Generic;

namespace GraphColoring.Application.Dtos.Graphs.Responses
{
    public class GetGraphByIdResponse
    {
        public GetGraphByIdResponse(List<List<int>> adjacencyMatrix)
        {
            AdjacencyMatrix = adjacencyMatrix;
        }

        public List<List<int>> AdjacencyMatrix { get; set; }
    }
}
