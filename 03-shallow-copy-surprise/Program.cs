DroneVault vault = new DroneVault();
vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));

List<Drone> copy = vault.GetDrones();
copy.RemoveAt(0);
copy[0].Name = "Foxtrot";
// TODO: Eksperimenter med RemoveAt og deretter endring av Name.

Console.WriteLine($"Vault count: {vault.Count}");
vault.PrintAll();
