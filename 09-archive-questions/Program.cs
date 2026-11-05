List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};

var hasHighRisk = artifacts.Any(artifact => artifact.Risk > 90);

    Console.WriteLine($"Risk is above 90: {hasHighRisk}");

var marsCount = artifacts.Count(artifact => artifact.Origin == "Mars");

    Console.WriteLine($"Mars artifacts: {marsCount}");

var totalCount = artifacts.Count();

    Console.WriteLine($"There are {totalCount} aritfacts");

var hasVenus = artifacts.Any(artifact => artifact.Origin == "Venus");

    Console.WriteLine($"TArtifacts from venus: {hasVenus}");



// TODO: Bruk Any og Count til å svare på spørsmålene.
