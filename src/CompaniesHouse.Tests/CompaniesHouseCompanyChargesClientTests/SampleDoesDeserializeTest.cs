using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.CompaniesHouseCompanyChargesClientTests
{
    [TestFixture]
    public class SimpleDeserializeTest
    {


        [Test]
        public void Sample1_Deserializes_Correctly()
        {
            string sample = $@"{{
    ""unfiltered_count"": 2,
    ""satisfied_count"": 0,
    ""total_count"": 2,
    ""items"": [
        {{
            ""created_on"": ""2015-06-25"",
            ""links"": {{
                ""self"": ""/company/09448445/charges/T7iHmWXIj8_5eqcQKZvvv98EXLQ""
            }},
            ""transactions"": [
                {{
                    ""delivered_on"": ""2015-06-26"",
                    ""links"": {{
                        ""filing"": ""/company/09448445/filing-history/MzEyNTkyODMxNWFkaXF6a2N4""
                    }},
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""particulars"": {{
                ""floating_charge_covers_all"": true,
                ""contains_floating_charge"": true,
                ""type"": ""brief-description"",
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true,
                ""description"": ""None.""
            }},
            ""charge_code"": ""094484450002"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Lloyds Bank PLC""
                }}
            ],
            ""charge_number"": 2,
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""status"": ""outstanding"",
            ""etag"": ""8196c073051c698ac60ff7b8a76979c8aba8f139"",
            ""delivered_on"": ""2015-06-26""
        }},
        {{
            ""created_on"": ""2015-05-28"",
            ""charge_code"": ""094484450001"",
            ""transactions"": [
                {{
                    ""delivered_on"": ""2015-06-11"",
                    ""filing_type"": ""create-charge-with-deed"",
                    ""links"": {{
                        ""filing"": ""/company/09448445/filing-history/MzEyNTQ2OTI0NGFkaXF6a2N4""
                    }}
                }}
            ],
            ""charge_number"": 1,
            ""links"": {{
                ""self"": ""/company/09448445/charges/JM5OpPem9d8lmWzelGPC6w6qcv0""
            }},
            ""particulars"": {{
                ""contains_floating_charge"": true,
                ""description"": ""The crown & cushion, birchfield road, birmingham."",
                ""contains_fixed_charge"": true,
                ""type"": ""brief-description""
            }},
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""etag"": ""99fb1d0a98e0b9083ec81dcc6bb09ec9941f08e4"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Lloyds Bank PLC""
                }}
            ],
            ""status"": ""outstanding"",
            ""delivered_on"": ""2015-06-11""
        }}
    ],
    ""part_satisfied_count"": 0
}}";

            CompanyCharges item = JsonConvert.DeserializeObject<CompanyCharges>(sample);

            Assert.That(item.PartSatisfiedCount == 0);
        }

        [Test]
        public void Sample2_Deserializes_Correctly()
        {
            string sample = $@"{{
    ""satisfied_count"": 10,
    ""items"": [
        {{
            ""charge_number"": 60,
            ""delivered_on"": ""2018-01-08"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Cheltenham Securities 2017 Limited""
                }}
            ],
            ""transactions"": [
                {{
                    ""delivered_on"": ""2018-01-08"",
                    ""filing_type"": ""create-charge-with-deed"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE5NDcwNjc0OGFkaXF6a2N4""
                    }}
                }}
            ],
            ""links"": {{
                ""self"": ""/company/00002065/charges/XlPPFh5zekNA5bzdm6pzJt4ZVEA""
            }},
            ""charge_code"": ""000020650060"",
            ""status"": ""outstanding"",
            ""particulars"": {{
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true,
                ""description"": ""Not applicable."",
                ""type"": ""brief-description""
            }},
            ""created_on"": ""2017-12-28"",
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""etag"": ""4dc0d7c0df6cbdf98275d1ca9b6b7adacd22e029""
        }},
        {{
            ""etag"": ""1af5209c90ae97d8a486730d4e5b13758f808d04"",
            ""charge_code"": ""000020650059"",
            ""particulars"": {{
                ""type"": ""brief-description"",
                ""description"": ""Not applicable."",
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""created_on"": ""2017-12-21"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/Yr9XmQ0DG64366TQ2VV9lIHFBfg""
            }},
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE5MzY1NTI1OWFkaXF6a2N4""
                    }},
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2017-12-22""
                }}
            ],
            ""status"": ""outstanding"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Wetherby Securities 2017 Limited""
                }}
            ],
            ""charge_number"": 59,
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""delivered_on"": ""2017-12-22""
        }},
        {{
            ""etag"": ""62f9f1565de23247bb222836ab9194631450e937"",
            ""charge_code"": ""000020650058"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/Aq2DghwZ5efqJZxcoDZreZIlWCg""
            }},
            ""particulars"": {{
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true
            }},
            ""created_on"": ""2017-10-09"",
            ""charge_number"": 58,
            ""persons_entitled"": [
                {{
                    ""name"": ""The Governor and Company of the Bank of England, Threadneedle Street, London, EC2R 8AH (In Its Capacity as Security Trustee for Itself and the Beneficiaries as Defined in the Attached Deed of Charge to Which This MR01 Relates)""
                }}
            ],
            ""status"": ""outstanding"",
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE4NzM1OTY2OWFkaXF6a2N4""
                    }},
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2017-10-09""
                }}
            ],
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""delivered_on"": ""2017-10-09""
        }},
        {{
            ""created_on"": ""2017-08-02"",
            ""etag"": ""1d5b053a7a04be056f2fbcf3dc5b23ee4ec36b9f"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/4RH8bCs-If8LQ3K8F9caWCoNlFY""
            }},
            ""particulars"": {{
                ""description"": ""A first fixed charge over all the agreements and the related rights (as defined in the instrument)."",
                ""contains_negative_pledge"": true,
                ""type"": ""brief-description""
            }},
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE4MjU2MzgyNWFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2017-08-09"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""persons_entitled"": [
                {{
                    ""name"": ""Scottish Widows Limited""
                }}
            ],
            ""charge_number"": 57,
            ""status"": ""outstanding"",
            ""charge_code"": ""000020650057"",
            ""delivered_on"": ""2017-08-09""
        }},
        {{
            ""links"": {{
                ""self"": ""/company/00002065/charges/ie5Ii5a1xfMXX5JsSDzc64QY8oM""
            }},
            ""particulars"": {{
                ""contains_fixed_charge"": true
            }},
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""etag"": ""8f1e61531d9ea8bbdb83f9f454ea6ab7f290fc9d"",
            ""status"": ""outstanding"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Fontwell Securities 2016 Limited""
                }}
            ],
            ""delivered_on"": ""2016-12-23"",
            ""charge_number"": 56,
            ""charge_code"": ""000020650056"",
            ""created_on"": ""2016-12-22"",
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE2NTI0OTA4MWFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2016-12-23"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ]
        }},
        {{
            ""status"": ""outstanding"",
            ""created_on"": ""2016-12-09"",
            ""charge_number"": 55,
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2016-12-15"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE2NDU1NDc4OGFkaXF6a2N4""
                    }}
                }}
            ],
            ""links"": {{
                ""self"": ""/company/00002065/charges/BQ5P1dbQd2AlypTKKsE_wmB--eA""
            }},
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""particulars"": {{
                ""contains_fixed_charge"": true
            }},
            ""etag"": ""25e1b1e14e20ae564117b7d277159831ea958e10"",
            ""charge_code"": ""000020650055"",
            ""delivered_on"": ""2016-12-15"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Salisbury Ii Securties 2016 Limited""
                }}
            ]
        }},
        {{
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE1MjE5MzkxM2FkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2016-07-04"",
                    ""filing_type"": ""create-charge-with-deed""
                }},
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE1MjMyNzI0MmFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2016-07-05"",
                    ""filing_type"": ""charge-satisfaction""
                }}
            ],
            ""etag"": ""634cf5b00c170dbfde608385ab4979e2e6bf9725"",
            ""charge_code"": ""000020650053"",
            ""created_on"": ""2016-06-24"",
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""persons_entitled"": [
                {{
                    ""name"": ""Jarvis New Homes (South East) Limited""
                }}
            ],
            ""particulars"": {{
                ""contains_floating_charge"": true,
                ""contains_fixed_charge"": true,
                ""type"": ""brief-description"",
                ""floating_charge_covers_all"": true,
                ""description"": ""Freehold land on the north west side and west side of ram lane, hothfield, ashford, kent, TN25 4LS (land registry title number: K368571)."",
                ""contains_negative_pledge"": true
            }},
            ""status"": ""fully-satisfied"",
            ""satisfied_on"": ""2016-07-05"",
            ""delivered_on"": ""2016-07-04"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/YvoSmcdll2x-o-EojQ5bvlKRWec""
            }},
            ""charge_number"": 53
        }},
        {{
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""delivered_on"": ""2016-06-03"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Eurex Clearing Ag""
                }}
            ],
            ""status"": ""outstanding"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/hIVL3sfCEVvClOG5UF4DHaRiTr4""
            }},
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE1MDUxMDQyMmFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2016-06-03"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""created_on"": ""2016-06-03"",
            ""charge_code"": ""000020650052"",
            ""charge_number"": 52,
            ""etag"": ""7cf340e98b1d3b5f59eff53d0f7f092ec7dc61b0"",
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_floating_charge"": true
            }}
        }},
        {{
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2015-12-21"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzODcwNDI0OWFkaXF6a2N4""
                    }}
                }}
            ],
            ""created_on"": ""2015-12-17"",
            ""charge_code"": ""000020650051"",
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""status"": ""outstanding"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/A3NvH24Ko3fQBTblNxtqwsM2hBY""
            }},
            ""etag"": ""5552a1dc1cbdf5016406ecc52e302228ca30c7bb"",
            ""delivered_on"": ""2015-12-21"",
            ""persons_entitled"": [
                {{
                    ""name"": ""U.S. Bank Trustees Limited (The Trustee)""
                }}
            ],
            ""charge_number"": 51,
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }}
        }},
        {{
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""charge_code"": ""000020650050"",
            ""etag"": ""3315ebcaa2e531f0f77b32eb93a05b124c38238d"",
            ""status"": ""outstanding"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/qowh_5W6PiD4cBCzFfKStVuTRak""
            }},
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""persons_entitled"": [
                {{
                    ""name"": ""Kfw""
                }}
            ],
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzNjA5MDY1NGFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2015-11-26"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""delivered_on"": ""2015-11-26"",
            ""created_on"": ""2015-11-26"",
            ""charge_number"": 50
        }},
        {{
            ""persons_entitled"": [
                {{
                    ""name"": ""Kfw""
                }}
            ],
            ""links"": {{
                ""self"": ""/company/00002065/charges/L_qpxcKwyztIGy8XpOal8IhtIiw""
            }},
            ""particulars"": {{
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true
            }},
            ""status"": ""outstanding"",
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""charge_code"": ""000020650049"",
            ""etag"": ""c1d4cfbc6d5d4a2ddf410a97f099e72a0108711d"",
            ""delivered_on"": ""2015-11-26"",
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzNjA5MDIwNWFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2015-11-26""
                }}
            ],
            ""charge_number"": 49,
            ""created_on"": ""2015-11-26""
        }},
        {{
            ""delivered_on"": ""2015-11-26"",
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzNjA4OTYwMmFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2015-11-26"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""charge_number"": 48,
            ""created_on"": ""2015-11-26"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/zVXy1Ley4QuukTzBD3dzzYyPX4g""
            }},
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""persons_entitled"": [
                {{
                    ""name"": ""Kfw Represented by Kfw Ipex-Bank Gmbh""
                }}
            ],
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""charge_code"": ""000020650048"",
            ""etag"": ""9e9c2496779ebd62d4abf5c0c40ea219862d02f1"",
            ""status"": ""outstanding""
        }},
        {{
            ""etag"": ""a5988115446738b243e0084312f72a60ff221bc4"",
            ""charge_code"": ""000020650047"",
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""status"": ""outstanding"",
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""links"": {{
                ""self"": ""/company/00002065/charges/AtLsCw1amQmU7Co-W_aWUpBPB-Y""
            }},
            ""persons_entitled"": [
                {{
                    ""name"": ""Kfw Represented by Kfw Ipex-Bank Gmbh""
                }}
            ],
            ""charge_number"": 47,
            ""created_on"": ""2015-11-26"",
            ""delivered_on"": ""2015-11-26"",
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzNjA4OTA4NWFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2015-11-26""
                }}
            ]
        }},
        {{
            ""particulars"": {{
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true
            }},
            ""status"": ""outstanding"",
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2015-09-29"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzMjE5NTYyNmFkaXF6a2N4""
                    }}
                }}
            ],
            ""charge_number"": 46,
            ""charge_code"": ""000020650046"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/ucWDk7f9uofBh8tmSpK_xboBoY0""
            }},
            ""created_on"": ""2015-09-21"",
            ""persons_entitled"": [
                {{
                    ""name"": ""The Governor and Company of the Bank of England (Security Trustee for the Security Beneficiaries)""
                }}
            ],
            ""delivered_on"": ""2015-09-29""
        }},
        {{
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""status"": ""outstanding"",
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2015-09-29"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEzMjE5MTE5OGFkaXF6a2N4""
                    }}
                }}
            ],
            ""charge_code"": ""000020650045"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/HYvBZTg0ERFuAMMhRB2FN3QS8jk""
            }},
            ""charge_number"": 45,
            ""persons_entitled"": [
                {{
                    ""name"": ""The Governor and Company of the Bank of England (Security Trustee for the Security Beneficiaries)""
                }}
            ],
            ""delivered_on"": ""2015-09-29"",
            ""created_on"": ""2015-09-21""
        }},
        {{
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzExODkwNTkyNWFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2015-03-02"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""particulars"": {{
                ""contains_fixed_charge"": true
            }},
            ""status"": ""outstanding"",
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""created_on"": ""2015-02-20"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Aviva Insurance Limited as Secured Party""
                }}
            ],
            ""delivered_on"": ""2015-03-02"",
            ""charge_number"": 44,
            ""charge_code"": ""000020650044"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/RcB9vs0mQQNikn-akMa41aa9we0""
            }}
        }},
        {{
            ""delivered_on"": ""2014-12-18"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Arkle Funding (No.1) Limited""
                }}
            ],
            ""created_on"": ""2014-12-11"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/HdJGKox03sK_I2hb-l57yiXPZf8""
            }},
            ""charge_code"": ""000020650043"",
            ""charge_number"": 43,
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzExNDE5MTAzMGFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2014-12-18"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""particulars"": {{
                ""contains_negative_pledge"": true,
                ""contains_fixed_charge"": true
            }},
            ""status"": ""outstanding""
        }},
        {{
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""particulars"": {{
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true
            }},
            ""status"": ""outstanding"",
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2014-12-15"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzExNDA3NTUwMWFkaXF6a2N4""
                    }}
                }}
            ],
            ""charge_code"": ""000020650042"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/iSN4qp7mhiMymzZJPkN-kD-xAoQ""
            }},
            ""charge_number"": 42,
            ""persons_entitled"": [
                {{
                    ""name"": ""The Royal Bank of Scotland PLC""
                }}
            ],
            ""delivered_on"": ""2014-12-15"",
            ""created_on"": ""2014-12-10""
        }},
        {{
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""status"": ""outstanding"",
            ""particulars"": {{
                ""contains_fixed_charge"": true,
                ""contains_negative_pledge"": true
            }},
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzExMTA0MTU0NmFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2014-11-05"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""charge_code"": ""000020650041"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/g-NKttfkjH1NiGBQNPjsoG3uDIM""
            }},
            ""charge_number"": 41,
            ""persons_entitled"": [
                {{
                    ""name"": ""Hart 2014-1 Limited""
                }}
            ],
            ""delivered_on"": ""2014-11-05"",
            ""created_on"": ""2014-10-30""
        }},
        {{
            ""assets_ceased_released"": ""whole-property-released"",
            ""etag"": ""f239390f7d5950898e5695b3edb7b33b005b3402"",
            ""particulars"": {{
                ""contains_floating_charge"": true,
                ""contains_negative_pledge"": true
            }},
            ""charge_code"": ""000020650040"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/8AU29RjoD6OjlN2RYGjW-ju4TjM""
            }},
            ""created_on"": ""2014-06-10"",
            ""delivered_on"": ""2014-06-24"",
            ""status"": ""outstanding"",
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }},
            ""transactions"": [
                {{
                    ""filing_type"": ""create-charge-with-deed"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzEwMjc1NzM0M2FkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2014-06-24""
                }},
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzE1MzI4Njk3N2FkaXF6a2N4""
                    }},
                    ""filing_type"": ""charge-whole-release"",
                    ""delivered_on"": ""2016-07-04""
                }}
            ],
            ""charge_number"": 40,
            ""persons_entitled"": [
                {{
                    ""name"": ""Eurex Clearing Ag""
                }}
            ]
        }},
        {{
            ""created_on"": ""2014-01-29"",
            ""delivered_on"": ""2014-02-04"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Bank of America N.A., Acting Through Its London Branch""
                }}
            ],
            ""charge_number"": 39,
            ""links"": {{
                ""self"": ""/company/00002065/charges/ZN_N_aKd9Zs8lHyETUmtC4AzCto""
            }},
            ""charge_code"": ""000020650039"",
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzA5NDAwMDE1MmFkaXF6a2N4""
                    }},
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2014-02-04""
                }}
            ],
            ""particulars"": {{
                ""contains_floating_charge"": true,
                ""contains_fixed_charge"": true
            }},
            ""status"": ""outstanding"",
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }}
        }},
        {{
            ""charge_code"": ""000020650038"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/d48UJjBAxmYwqxMpQOwPDMytlSg""
            }},
            ""charge_number"": 38,
            ""persons_entitled"": [
                {{
                    ""name"": ""Euroclear Bank Sa/Nv""
                }}
            ],
            ""delivered_on"": ""2013-12-05"",
            ""created_on"": ""2013-11-21"",
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""particulars"": {{
                ""contains_floating_charge"": true,
                ""description"": ""Notification of addition to or amendment of charge."",
                ""type"": ""brief-description""
            }},
            ""status"": ""outstanding"",
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzA5MDMxODEzNGFkaXF6a2N4""
                    }},
                    ""filing_type"": ""create-charge-with-deed"",
                    ""delivered_on"": ""2013-12-05""
                }}
            ]
        }},
        {{
            ""created_on"": ""2013-08-20"",
            ""delivered_on"": ""2013-09-05"",
            ""persons_entitled"": [
                {{
                    ""name"": ""The Governor and Company of the Bank of England (As Security Trustee)""
                }}
            ],
            ""charge_number"": 37,
            ""links"": {{
                ""self"": ""/company/00002065/charges/oo5PV7PXQqHto7tA55IWoKB5WW8""
            }},
            ""charge_code"": ""000020650037"",
            ""transactions"": [
                {{
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzA4NTIyNTI3MGFkaXF6a2N4""
                    }},
                    ""delivered_on"": ""2013-09-05"",
                    ""filing_type"": ""create-charge-with-deed""
                }}
            ],
            ""status"": ""outstanding"",
            ""particulars"": {{
                ""type"": ""brief-description"",
                ""description"": ""Notification of addition to or amendment of charge."",
                ""contains_fixed_charge"": true
            }},
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""A registered charge""
            }}
        }},
        {{
            ""transactions"": [
                {{
                    ""delivered_on"": ""2013-06-28"",
                    ""filing_type"": ""create-charge-with-deed"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzA4MDYzMzI2OWFkaXF6a2N4""
                    }}
                }},
                {{
                    ""delivered_on"": ""2013-07-03"",
                    ""filing_type"": ""charge-satisfaction"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzA4MTA1NzAyM2FkaXF6a2N4""
                    }}
                }}
            ],
            ""classification"": {{
                ""description"": ""A registered charge"",
                ""type"": ""charge-description""
            }},
            ""particulars"": {{
                ""contains_floating_charge"": true,
                ""description"": ""42 fairway north. Bromborough. Wirral. CH62 3LZ. Registered at hm land registry under title number: MS601237."",
                ""contains_fixed_charge"": true,
                ""type"": ""brief-description"",
                ""floating_charge_covers_all"": true
            }},
            ""status"": ""fully-satisfied"",
            ""delivered_on"": ""2013-06-28"",
            ""persons_entitled"": [
                {{
                    ""name"": ""Lloyds Bank Tsb PLC""
                }}
            ],
            ""satisfied_on"": ""2013-07-03"",
            ""created_on"": ""2013-06-19"",
            ""links"": {{
                ""self"": ""/company/00002065/charges/lrnesXcLTZ9Orx330W9VXATGy1o""
            }},
            ""charge_code"": ""000020650036"",
            ""charge_number"": 36
        }},
        {{
            ""charge_number"": 35,
            ""links"": {{
                ""self"": ""/company/00002065/charges/lOBBc4LtAi8ldb4l-uIhP8QQovw""
            }},
            ""created_on"": ""2013-01-08"",
            ""delivered_on"": ""2013-01-10"",
            ""persons_entitled"": [
                {{
                    ""name"": ""The Governor and Company of the Bank of England (As Security Trustee for the Security Beneficiaries)""
                }}
            ],
            ""particulars"": {{
                ""description"": ""All rights and interest in respect of all securities and amounts standing to the credit of its securities account and the entitlements or debts, its securities account and the credit balance on its cash account see image for full details."",
                ""type"": ""short-particulars""
            }},
            ""status"": ""outstanding"",
            ""secured_details"": {{
                ""description"": ""All monies due or to become due from the company to any beneficiary and the chargee on any account whatsoever under the terms of the aforementioned instrument creating or evidencing the charge"",
                ""type"": ""amount-secured""
            }},
            ""classification"": {{
                ""type"": ""charge-description"",
                ""description"": ""Deed of charge""
            }},
            ""transactions"": [
                {{
                    ""delivered_on"": ""2013-01-10"",
                    ""filing_type"": ""create-charge-pre-april-2013"",
                    ""links"": {{
                        ""filing"": ""/company/00002065/filing-history/MzA3MTEwODIxNGFkaXF6a2N4""
                    }}
                }}
            ]
        }}
    ],
    ""part_satisfied_count"": 0,
    ""unfiltered_count"": 57,
    ""total_count"": 57
}}";

            CompanyCharges item = JsonConvert.DeserializeObject<CompanyCharges>(sample);

            Assert.That(item.PartSatisfiedCount == 0);
        }



    }
}
