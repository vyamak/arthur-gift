

using var titi = new DadContext();
titi.Database.CreateSchema();
titi.Children.Add(new Child
{
    Name = "Arthur",
    BornAt = new DateTime(2023, 12, 14),
    WeightInKg = 2.3,
    HeightInCm = 47,
});
await titi.SaveChangesAsync();


    















