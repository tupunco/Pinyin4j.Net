using System.IO;
using System.Xml;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// A class contains resource that translates from Hanyu Pinyin to Gwoyeu
    /// Romatzyh
    /// </summary>
    internal class GwoyeuRomatzyhResource
    {
        /// <summary>
        /// Singleton Instance 
        /// </summary>
        public static readonly GwoyeuRomatzyhResource Instance = new GwoyeuRomatzyhResource();

        /// <summary>
        ///  A DOM model contains Hanyu Pinyin to Gwoyeu Romatzyh mapping
        /// </summary>
        private XmlDocument pinyinToGwoyeuMappingDoc = new XmlDocument();

        /// <summary>
        /// Private constructor as part of the singleton pattern.
        /// </summary>
        private GwoyeuRomatzyhResource()
        {
            initializeResource();
        }

        /// <summary>
        ///  A DOM model contains Hanyu Pinyin to Gwoyeu Romatzyh mapping
        /// </summary>
        public XmlDocument PinyinToGwoyeuMappingDoc
        {
            get { return pinyinToGwoyeuMappingDoc; }
            set { pinyinToGwoyeuMappingDoc = value; }
        }

        /// <summary>
        /// Initialiez a DOM contains Hanyu Pinyin to Gwoyeu mapping
        /// </summary>
        private void initializeResource()
        {
            try
            {
                string mappingFileName = "pinyindb.pinyin_gwoyeu_mapping.xml";

                // Parse file to DOM Document
                PinyinToGwoyeuMappingDoc.Load(ResourceHelper.GetResourceInputStream(mappingFileName));
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (XmlException e)
            {
                throw e;
            }
        }
    }
}