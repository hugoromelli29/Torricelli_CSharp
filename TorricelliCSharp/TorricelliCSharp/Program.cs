using TorricelliCSharp;

/*
fórmula de Torricelli: v² = v0² + 2a∆S
Dados: v0 = 2m/s; a = 2m/s²; sf = 20m; s0 = 12m
Calcule: v
*/

Torricelli oepracao = new();
oepracao.S0 = 12;
oepracao.Sf = 20;
oepracao.V0 = 2;
oepracao.a = 2;
oepracao.CalcTorricelli();

Console.ReadKey();