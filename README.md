# Pinyin4j.Net

## 介绍
- Pinyin4j 主页 http://pinyin4j.sourceforge.net/
- Pinyin4j.Net 主页 http://www.codeplex.com/npinyin4j
- Pinyin4j是一提供中文字符转化成多种可定制拼音系统的类库,- Pinyin4j.Net是其在.Net 2.0 平台的实现.

## Pinyin4j 提供汉字转化成以下拼音系统
- Hanyu Pinyin 汉语拼音
- Tongyong Pinyin 通用拼音
- Wade-Giles 威妥玛拼音
- MPS2 (Mandarin Phonetic Symbols II) 国语注音符号第二式
- Yale Romanization 耶鲁罗马化拼音
- Gwoyeu Romatzyh 国语国语罗马化拼音

==============================
## 升级日志
### 2007-8-27
- Pinyin4j.Net 2.5 版代码进行了重构
- 加入 Winform 的 Demo 程序(实现汉字长句转化成任何拼音方式)
- 配件加入强命名

### 2007-8-17
- Pinyin4j.Net 2.5 版 提供 Pinyin4j 的所有功能

-------------------------------------------------

Readme of pinyin4j

Table of content
I. 	Main Features
II. Future work
III.How to install
IV. Getting start
V. 	Author
VI.	Copyright

I. Main Features

1. Support convertion from Chinese character (both Simplified and Tranditional) to different Chinese Romanization systems
2. Support various target Chinese Romanization systems, including Hanyu Pinyin, Tongyong Pinyin, Wade-Giles, MPS2 (Mandarin Phonetic Symbols 2), Yale and Gwoyeu Romatzyh
2. Support multiple pronounciations of a single Chinese character
3. Several output format 
3.1. Uppercase or lowercase
3.2. v or u: or unicode ü
3.3. unicode output with tone numbers, with tone marks or without tone

II. Future work

1. Provide format functions to other Chinese Romanization systems excluding Hanyu Pinyin
2. Provide Pinyin to Chinese
3. Provide coverage test to discover unknown Chinese characters

III. How to install

1. Add lib/pinyin4j-2.5.0.jar to your classpath
2. Import necessary class files

import net.sourceforge.pinyin4j.PinyinHelper 
import net.sourceforge.pinyin4j.format.* // this import is necessary only when you use the output format function

IV. Getting start

1. open command-line window, type 
cd ${pinyin-install-dir}\lib

2. In lib directory, there is a JAR file named pinyin4j-2.5.0.jar, type 
java -jar pinyin4j-2.5.0.jar 
run the GUI demo application

3. If you want to modify the source and compile it, you may need download sparta.jar from http://sparta-xml.sourceforge.net/ and add it to classpath.
(Pinyin4j adds sparta-xml library into pinyin4j-2.5.0.jar file already. Therefore you don't need the sparta.jar if you simply use pinyin4j without re-compiling it.)

NOTE: the java files using pinyin4j should be save as unicode-supporting encoding, such as UTF-8

V. Author

Li Min (xmlerlimin@gmail.com)

You can reach me at:       
Blogger: http://lemann.blogspot.com/
My.Opera: http://my.opera.com/lemann/

VI.	Copyright
1. The dictionary file contains Chinese Unicode to Hanyu Pinyin mapping is got from internet, named "uc-to-py.tbl". The auther is stolfi.
2. The comparsion table among Tongyong Pinyin, Wade-Giles, MPS2, Yale, Hanyu Pinyin, and Gwoyeu Romatzyh are got from http://www.pinyin.info/romanization/compare/tongyong.html
3. The algorithm for placing tone marks is got from http://en.wikipedia.org/wiki/Pinyin#Rules_for_placing_the_tone_mark
4. The XML and XPath parsing library is got from http://sparta-xml.sourceforge.net/
5. The release of Pinyin4j library is based on GNU GENERAL PUBLIC LICENSE (GPL). See more details about GPL, please refer to COPYING.txt