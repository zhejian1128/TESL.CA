<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE xsl:stylesheet [  <!ENTITY nbsp "&#x00A0;">]>
<xsl:stylesheet
  version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:msxml="urn:schemas-microsoft-com:xslt" 
	xmlns:umbraco.library="urn:umbraco.library" xmlns:Exslt.ExsltCommon="urn:Exslt.ExsltCommon" xmlns:Exslt.ExsltDatesAndTimes="urn:Exslt.ExsltDatesAndTimes" xmlns:Exslt.ExsltMath="urn:Exslt.ExsltMath" xmlns:Exslt.ExsltRegularExpressions="urn:Exslt.ExsltRegularExpressions" xmlns:Exslt.ExsltStrings="urn:Exslt.ExsltStrings" xmlns:Exslt.ExsltSets="urn:Exslt.ExsltSets" xmlns:Examine="urn:Examine" 
	exclude-result-prefixes="msxml umbraco.library Exslt.ExsltCommon Exslt.ExsltDatesAndTimes Exslt.ExsltMath Exslt.ExsltRegularExpressions Exslt.ExsltStrings Exslt.ExsltSets Examine ">

  <xsl:output method="xml" omit-xml-declaration="yes"/>

  <xsl:param name="currentPage"/>

  <xsl:variable name="minLevel" select="1"/>

  <xsl:template match="/">

    <xsl:if test="$currentPage/@level &gt; $minLevel">
      <ul>
        <xsl:for-each select="$currentPage/ancestor::* [@level &gt; $minLevel and string(umbracoNaviHide) != '1']">
          <li>
            <a href="{umbraco.library:NiceUrl(@id)}">
              <xsl:value-of select="@nodeName"/>
            </a>
          </li>
			<li>
				>>
			</li>
        </xsl:for-each>
        <!-- print currentpage -->
        <li>
          <xsl:value-of select="$currentPage/@nodeName"/>
        </li>
      </ul>
    </xsl:if>
  </xsl:template>
</xsl:stylesheet>