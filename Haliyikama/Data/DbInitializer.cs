using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Haliyikama.Data.Models
{
	public class DbInitializer
	{
		public static void Seed(AppDbContext context)
		{
			
				//Hizmet - AltHizmet
		    if (!context.Hizmetler.Any())
				{
					context.Hizmetler.AddRange(Hizmetler.Select(c => c.Value));
				}
			if (!context.AltHizmetler.Any())
				{
					context.AddRange
					(

						new AltHizmet
						{
							Name = "Althizmet1",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama"]
						},
						new AltHizmet
						{
							Name = "Althizmet2",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama"]

						},
						new AltHizmet
						{
							Name = "Althizmet21",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama2"]
						},
						new AltHizmet
						{
							Name = "Althizmet31",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama3"]
						}
						);
				}



				//Ilceler And Semtler Data 
			if (!context.Ilceler.Any())
			{
				context.Ilceler.AddRange(Ilceler.Select(c => c.Value));
			}
			if (!context.Semtler.Any())
			{
				context.AddRange
					(
					new Semt
					{
						Name ="Basak Mah",
						Description ="yazi burda",
						Ilce  = Ilceler["Arnavutköy"]
						
					},
					new Semt
					{
						Name ="Beyan",
						Description="yazi burda",
						Ilce = Ilceler["Arnavutköy"]
					},
					new Semt
					{
						Name = "Beyan2",
						Description = "yazi burda",
						Ilce = Ilceler["Avcılar"]
					}
					);
			}
			


			//Hakkimizda
			if (!context.Hakkimizda.Any())
			{
				context.Hakkimizda.AddRange(Hakkimizda.Select(c => c.Value));
			}

			// Fiya Listesi
			if (!context.FiyatListesi.Any())
			{
				context.FiyatListesi.AddRange(FiyatListesi.Select(c => c.Value));
			}

			//Faydali Bilgiler
			if (!context.Blog.Any())
			{
				context.Blog.AddRange(Blog.Select(c => c.Value));
			}

			//Iletisim
			if (!context.Iletisim.Any())
			{
				context.Iletisim.AddRange(Iletisim.Select(c => c.Value));
			}

		 context.SaveChanges();  
			
		}
		//HIZMETLER - ALTHIZMETLER
		private static Dictionary<string, Hizmet> hizmetler;
		public static Dictionary<string, Hizmet> Hizmetler
		{
			get
			{
				if (hizmetler == null)
				{
					var genersList = new Hizmet[]
					{
						new Hizmet
						{
							Name = "HaliYikama",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 12,
							NewPrice = 10,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = false
						},
						new Hizmet
						{
							Name = "HaliYikama2",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 10,
							NewPrice = 9,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = true
						},
						new Hizmet
						{
							Name = "HaliYikama3",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 12,
							NewPrice = 10,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = false
						},
						new Hizmet
						{
							Name = "HaliYikama4",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 10,
							NewPrice = 9,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = true
						}
					};
					hizmetler = new Dictionary<string, Hizmet>();
					foreach (Hizmet genre in genersList)
					{
						hizmetler.Add(genre.Name, genre);
					}
				}
				return hizmetler;
			}
		}

		// ILCELER - SEMTLER
		private static Dictionary<string, Ilce> ilceler;
		public static Dictionary<string, Ilce> Ilceler
		{
			get
			{
				if (ilceler == null)
				{
					var genersList = new Ilce[]
					{
						new Ilce
						{
							Name="Arnavutköy",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Ataşehir",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Avcılar",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Bağcılar",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Bahçelievler",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Bakırköy",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						}

					};
					ilceler = new Dictionary<string, Ilce>();
					foreach (Ilce genre in genersList)
					{
						ilceler.Add(genre.Name, genre);
					}
				}
				return ilceler;
			}
		}

		// HAKKIMIZDA

		public static Dictionary<string, Hakkimizda> hakkimizda;
		public static Dictionary<string, Hakkimizda> Hakkimizda
		{
			get
			{
				if(hakkimizda == null)
				{
					var genersList = new Hakkimizda[]
					{
						new Hakkimizda
						{
							Title="Artirex",
							Description = "Artirex, temsil ettiği firmalara, internet konulu kurumsal çözüm ve danışmanlık hizmetleri vermek için kurulmuştur. Kuruluş yılı 2014’den günümüze dek iş ortaklarının güveni ve sadakatine yön vermek, vazgeçilmez bir çözüm ortağı olmak, web tasarım işinde bir numara olmak için; yenilikçi, yüksek kaliteli, profesyonel hizmetler vermektedir.",
							ImageURL = "http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"
						}
					};
					hakkimizda = new Dictionary<string, Hakkimizda>();
					foreach (Hakkimizda gener in genersList)
					{
						hakkimizda.Add(gener.Title, gener);
					}
				}
				return hakkimizda;
			}
		}

		//FIYATLISTESI
		public static Dictionary<string, FiyatListesi> fiyatListesi;
		public static Dictionary<string, FiyatListesi> FiyatListesi
		
		{	get
			{
				if(fiyatListesi == null)
				{
					var generList = new FiyatListesi[]
					{
						new FiyatListesi
						{
							Name="HaliYikama",
							Price="10"
						},
						new FiyatListesi
						{
							Name="StepHali Yikama",
							Price="4"
						},
						new FiyatListesi
						{
							Name="Koltuk Yikama",
							Price ="15"
						}
					};
					fiyatListesi = new Dictionary<string, FiyatListesi>();
					foreach(FiyatListesi gener in generList)
					{
						fiyatListesi.Add(gener.Name, gener);
					}
				}
				return fiyatListesi;
			}
		}

		//FAYDALIBILGILER
		public static Dictionary<string, Blog> blog;
		public static Dictionary<string, Blog> Blog
		{
			get
			{
				if(blog == null)
				{
					var generList = new Blog[]
					{
						new Blog
						{
							Name = "Blog1",
							ShortDescription ="Kisa yazi Burda ",
							LongDescription ="uzun yazi burda",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg",
							DateOfPublish = DateTime.Now
						},
						new Blog
						{
							Name = "Blog2",
							ShortDescription ="Kisa yazi Burda ",
							LongDescription ="uzun yazi burda",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg",
							DateOfPublish = DateTime.Now
						}
					};
					blog = new Dictionary<string, Blog>();
					foreach (Blog gener in generList)
					{
						blog.Add(gener.Name, gener);
					}
				}
				return blog;
			}
		}

		//ILETISIM
		public static Dictionary<string, Iletisim> iletisim;
		public static Dictionary<string, Iletisim> Iletisim
		{
			get
			{
				if (iletisim == null)
				{
					var generList = new Iletisim[]
					{
						 new Iletisim
						{
						Address = " Adres Burda",
						Email = " E posta Burda",
						Phone1 = "cep telefon burda",
						Phone2 = "cep telefon2 burda",
						ShortDescription = "kisa yazi burda",
						MapLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3652.1435118487834!2d73.09695287259558!3d23.742261243014283!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x395d97dd1a0a0f73%3A0x1c89ba6d8d4d240!2sBolundra%2C+Gujarat+383421!5e0!3m2!1sen!2sin!4v1500617103857"
						}
					};
					iletisim = new Dictionary<string, Iletisim>();
					foreach (Iletisim gener in generList)
					{
						iletisim.Add(gener.Address, gener);
					}

				}
				return iletisim;
			}
		}

	}
}
