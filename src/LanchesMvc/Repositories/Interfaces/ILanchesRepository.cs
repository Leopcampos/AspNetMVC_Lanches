﻿using LanchesMvc.Models;

namespace LanchesMvc.Repositories.Interfaces
{
    public interface ILanchesRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}