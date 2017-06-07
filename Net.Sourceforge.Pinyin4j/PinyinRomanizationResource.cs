using System.IO;
using System.Xml;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// Contains the resource supporting translations among different Chinese
    /// Romanization systems
    /// </summary>
    internal class PinyinRomanizationResource
    {
        /// <summary>
        /// Singleton Instance 
        /// </summary>
        public static readonly PinyinRomanizationResource Instance = new PinyinRomanizationResource();

        /// <summary>
        ///  A DOM model contains variable pinyin presentations
        /// </summary>
        private XmlDocument pinyinMappingDoc = new XmlDocument();

        /// <summary>
        /// Private constructor as part of the singleton pattern.
        /// </summary>
        private PinyinRomanizationResource()
        {
            initializeResource();
        }

        /// <summary>
        ///  A DOM model contains variable pinyin presentations
        /// </summary>
        public XmlDocument PinyinMappingDoc
        {
            get { return pinyinMappingDoc; }
            set { pinyinMappingDoc = value; }
        }

        /// <summary>
        ///  Initialiez a DOM contains variable PinYin representations
        /// </summary>
        private void initializeResource()
        {
            try
            {
                string mappingFileName = "pinyindb.pinyin_mapping.xml";
                // Parse file to DOM Document
                PinyinMappingDoc.Load(ResourceHelper.GetResourceInputStream(mappingFileName));
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (XmlException ex)
            {
                throw ex;
            }
        }
    }
}