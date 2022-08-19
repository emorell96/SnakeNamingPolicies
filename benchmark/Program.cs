// See https://aka.ms/new-console-template for more information
using benchmark;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<SnakeCaseConventioneerBenchmark>();