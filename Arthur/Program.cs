

using var titi = new DadContext();
titi.Database.CreateSchema();
titi.Children.Add(new Child
{
    Name = "Arthur",
    BornAt = DateTime.Now,
    WeightInKg = 2.3,
});
titi.SaveChanges();


















