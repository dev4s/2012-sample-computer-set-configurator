using System.Collections.Generic;
using System.Data.Entity;

namespace SampleComputerSetConfigurator.Database
{
	public class InitializeSampleData : DropCreateDatabaseIfModelChanges<ComputerSetDatabaseContext>
	{
		protected override void Seed(ComputerSetDatabaseContext context)
		{
			//NOTE: sample data for database
			context.AdditionalServices.Add(new AdditionalService { Name = "Montaż", Price = 40 });
			context.AdditionalServices.Add(new AdditionalService { Name = "Instalacja", Price = 120 });
			context.AdditionalServices.Add(new AdditionalService { Name = "Dostawa", Price = 15 });

			var motherboardGroup = new ComputerPartGroup {Name = "Płyta główna", Parent = null};
			var cpg = new List<ComputerPartGroup>
			                            {
			                                new ComputerPartGroup {Name = "Procesor", Sequence = 1, Show = true, Parent = motherboardGroup},
			                                new ComputerPartGroup {Name = "Pamięć RAM", Sequence = 2, Show = true, Parent = motherboardGroup},
			                                new ComputerPartGroup {Name = "Dysk twardy", Sequence = 3, Show = true},
			                                new ComputerPartGroup {Name = "Napęd", Sequence = 4, Show = true},
			                                new ComputerPartGroup {Name = "Obudowa", Sequence = 5, Show = true}
			                            };
			cpg.ForEach(x => context.ComputerPartGroups.Add(x));

			var cpdt = new List<ComputerPartDetailType>
			         	{
							new ComputerPartDetailType {Id = 1, Name = "ProcessorSocket"},
							new ComputerPartDetailType {Id = 2, Name = "Memory"},
			         	};

			var cpd = new List<ComputerPartDetail>
			          	{
							new ComputerPartDetail {Id = 1, Name = "Socket 01", Type = cpdt[0]},
							new ComputerPartDetail {Id = 2, Name = "Socket 02", Type = cpdt[0]},
							new ComputerPartDetail {Id = 3, Name = "Socket 03", Type = cpdt[0]},
							new ComputerPartDetail {Id = 4, Name = "DDR1", Type = cpdt[1]},
							new ComputerPartDetail {Id = 5, Name = "DDR2", Type = cpdt[1]},
							new ComputerPartDetail {Id = 6, Name = "DDR3", Type = cpdt[1]}
			          	};

			cpdt.ForEach(x => context.ComputerPartDetailTypes.Add(x));
			cpd.ForEach(x => context.ComputerPartDetails.Add(x));

			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 01", Details = new[] { cpd[0], cpd[3] }, Group = motherboardGroup, Price = 120 });
			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 02", Details = new[] { cpd[1], cpd[4] }, Group = motherboardGroup, Price = 340 });
			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 03", Details = new[] { cpd[2], cpd[5] }, Group = motherboardGroup, Price = 847 });

			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 04", Details = new[] { cpd[0], cpd[3] }, Group = motherboardGroup, Price = 349 });
			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 05", Details = new[] { cpd[1], cpd[4] }, Group = motherboardGroup, Price = 678 });
			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 06", Details = new[] { cpd[2], cpd[5] }, Group = motherboardGroup, Price = 239 });

			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 07", Details = new[] { cpd[0], cpd[3] }, Group = motherboardGroup, Price = 230 });
			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 08", Details = new[] { cpd[1], cpd[4] }, Group = motherboardGroup, Price = 123 });
			context.ComputerParts.Add(new ComputerPart { Name = "Płyta główna 09", Details = new[] { cpd[2], cpd[5] }, Group = motherboardGroup, Price = 349 });

			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 01", Details = new[] { cpd[0] }, Group = cpg[0], Price = 200 });
			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 02", Details = new[] { cpd[0] }, Group = cpg[0], Price = 400 });
			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 03", Details = new[] { cpd[0] }, Group = cpg[0], Price = 550 });

			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 04", Details = new[] { cpd[1] }, Group = cpg[0], Price = 720 });
			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 05", Details = new[] { cpd[1] }, Group = cpg[0], Price = 330 });
			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 06", Details = new[] { cpd[1] }, Group = cpg[0], Price = 342 });

			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 07", Details = new[] { cpd[2] }, Group = cpg[0], Price = 234 });
			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 08", Details = new[] { cpd[2] }, Group = cpg[0], Price = 893 });
			context.ComputerParts.Add(new ComputerPart { Name = "Procesor 09", Details = new[] { cpd[2] }, Group = cpg[0], Price = 384 });

			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 01", Details = new[] { cpd[3] }, Group = cpg[1], Price = 100 });
			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 02", Details = new[] { cpd[3] }, Group = cpg[1], Price = 156 });
			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 03", Details = new[] { cpd[3] }, Group = cpg[1], Price = 395 });

			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 04", Details = new[] { cpd[4] }, Group = cpg[1], Price = 349 });
			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 05", Details = new[] { cpd[4] }, Group = cpg[1], Price = 233 });
			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 06", Details = new[] { cpd[4] }, Group = cpg[1], Price = 349 });

			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 07", Details = new[] { cpd[5] }, Group = cpg[1], Price = 594 });
			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 08", Details = new[] { cpd[5] }, Group = cpg[1], Price = 523 });
			context.ComputerParts.Add(new ComputerPart { Name = "Pamięć RAM 09", Details = new[] { cpd[5] }, Group = cpg[1], Price = 848 });

			context.ComputerParts.Add(new ComputerPart { Name = "Dysk twardy 01", Group = cpg[2], Price = 345 });
			context.ComputerParts.Add(new ComputerPart { Name = "Dysk twardy 02", Group = cpg[2], Price = 230 });
			context.ComputerParts.Add(new ComputerPart { Name = "Dysk twardy 03", Group = cpg[2], Price = 238 });

			context.ComputerParts.Add(new ComputerPart { Name = "Napęd optyczny 01", Group = cpg[3], Price = 123 });
			context.ComputerParts.Add(new ComputerPart { Name = "Napęd optyczny 02", Group = cpg[3], Price = 78 });
			context.ComputerParts.Add(new ComputerPart { Name = "Napęd optyczny 03", Group = cpg[3], Price = 348 });

			context.ComputerParts.Add(new ComputerPart { Name = "Obudowa 01", Group = cpg[4], Price = 589 });
			context.ComputerParts.Add(new ComputerPart { Name = "Obudowa 02", Group = cpg[4], Price = 349 });
			context.ComputerParts.Add(new ComputerPart { Name = "Obudowa 03", Group = cpg[4], Price = 800 });
			
			base.Seed(context);
		}
	}
}