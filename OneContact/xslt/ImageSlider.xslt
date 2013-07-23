<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE xsl:stylesheet [ <!ENTITY nbsp "&#x00A0;"> ]>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:msxml="urn:schemas-microsoft-com:xslt" 
	xmlns:umbraco.library="urn:umbraco.library" xmlns:Exslt.ExsltCommon="urn:Exslt.ExsltCommon" xmlns:Exslt.ExsltDatesAndTimes="urn:Exslt.ExsltDatesAndTimes" xmlns:Exslt.ExsltMath="urn:Exslt.ExsltMath" xmlns:Exslt.ExsltRegularExpressions="urn:Exslt.ExsltRegularExpressions" xmlns:Exslt.ExsltStrings="urn:Exslt.ExsltStrings" xmlns:Exslt.ExsltSets="urn:Exslt.ExsltSets" xmlns:Examine="urn:Examine" 
	exclude-result-prefixes="msxml umbraco.library Exslt.ExsltCommon Exslt.ExsltDatesAndTimes Exslt.ExsltMath Exslt.ExsltRegularExpressions Exslt.ExsltStrings Exslt.ExsltSets Examine ">

<xsl:output method="xml" omit-xml-declaration="yes" />

<xsl:param name="currentPage"/>

<!-- Input the documenttype you want here -->
<xsl:variable name="documentTypeAlias" select="string('slider')"/>

<xsl:template match="/">

<!-- The fun starts here -->
<ul>
	<xsl:for-each select="$currentPage/sliders/* [name() = $documentTypeAlias and string(umbracoNaviHide) != '1']">
		    <li>
                
                    <img src="{umbracoFile}" alt=""/>
				        


                    <div>
                        <p><xsl:value-of select="teaserText" disable-output-escaping="yes"/></p>
						
						<xsl:choose>						
        				<xsl:when test="new_win=9">
							<a href='{hyperlink}' target='_blank'><button class="red">Find out more</button></a>
						</xsl:when>
						<xsl:otherwise>
							<a href='{hyperlink}' ><button class="red">Find out more</button></a>
						</xsl:otherwise>	
						</xsl:choose>
                    </div>
                
            </li>
</xsl:for-each>
</ul>

</xsl:template>

</xsl:stylesheet>