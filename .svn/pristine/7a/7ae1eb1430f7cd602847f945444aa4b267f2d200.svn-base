<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE xsl:stylesheet [
    <!ENTITY nbsp "&#x00A0;">
]>
<xsl:stylesheet
  version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxml="urn:schemas-microsoft-com:xslt"
  xmlns:umbraco.library="urn:umbraco.library"
  exclude-result-prefixes="msxml umbraco.library">


    <xsl:output method="xml" omit-xml-declaration="yes" />

    <xsl:param name="currentPage"/>

    <!-- Input the documenttype you want here -->
    <xsl:variable name="level" select="1"/>

    <xsl:template match="/">

      
 <ul id="main">
 <xsl:for-each select="$currentPage/ancestor-or-self::* [@level=$level]/* [@isDoc and string(umbracoNaviHide) != '1']">
	 <xsl:if test="@id!=1114 and @id!=1101">
  <li>
    <a class="navigation" href="{umbraco.library:NiceUrl(@id)}">
      <span><xsl:value-of select="@nodeName"/></span>
    </a>
    <div class="dropdown">      
        <xsl:for-each select="@nodeName/ancestor-or-self::* [@level=2]/* [@isDoc and string(umbracoNaviHide) != '1']">
          <ul>
          <li>
			  <a href="{umbraco.library:NiceUrl(@id)}" class="navigation">
            <b>
              <xsl:value-of select="@nodeName"/>
            </b>
			  </a>
          </li>
          <xsl:for-each select="@nodeName/ancestor-or-self::* [@level=3]/* [@isDoc and string(umbracoNaviHide) != '1']">
            <li>
				<a href="{umbraco.library:NiceUrl(@id)}" class="subnavigation">
					<span><xsl:value-of select="@nodeName"/></span>
				</a>
            </li>            
          </xsl:for-each>
          </ul>
        </xsl:for-each>
      
    </div>
  </li>
  
	 </xsl:if>
</xsl:for-each>
</ul>

    </xsl:template>

</xsl:stylesheet>