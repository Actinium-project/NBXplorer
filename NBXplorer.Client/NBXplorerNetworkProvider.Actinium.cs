using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitActinium(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Actinium.Instance, networkType)
			{
				MinRPCVersion = 140200
			});
		}

		public NBXplorerNetwork GetACM()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Actinium.Instance.CryptoCode);
		}
	}
}
