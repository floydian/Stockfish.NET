﻿using System.Collections.Generic;
using Stockfish.NET.Models;

namespace Stockfish.NET
{
    public interface IStockfish
    {
        int Depth { get; set; }
        int SkillLevel { get; set; }
        void SetPosition(List<string> moves = null);
        string GetBoardVisual();
        string GetFenPosition();
        void SetFenPosition(string fenPosition);
        string GetBestMove();
        string GetBestMoveTime(int time = 1000);
        bool IsMoveCorrect(string moveValue);
        Evaluation GetEvaluation();
    }
}