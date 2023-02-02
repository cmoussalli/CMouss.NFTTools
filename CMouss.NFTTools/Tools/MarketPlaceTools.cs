//namespace CMouss.NFTTools
//{
//    public class MarketPlaceTools
//    {

//        public string GetChainName(string nftUrl)
//        {
//            string result = "";
//            if (!String.IsNullOrEmpty(nftUrl))
//            {

//                //OpenSea
//                if (nftUrl.ToLower().Contains("opensea.io"))
//                {
//                    string[] temps = nftUrl.Substring(nftUrl.IndexOf("assets") + 7).Split(@"/");
//                    result = temps[0];
//                }
//            }
//            return result;
//        }

//    }
//}