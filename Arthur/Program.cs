using var titi = new DadContext();
await titi.Database.EnsureCreatedAsync();
titi.Children.Add(new Child
{
    Name = "Arthur",
    BornAt = new DateTime(2023, 12, 13),
    WeightInKg = 2.3,
    HeightInCm = 47,
});
await titi.SaveChangesAsync();


    















