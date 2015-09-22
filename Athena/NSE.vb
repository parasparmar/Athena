Option Explicit On
Public Class NSE
    Public Property URL As String
    Public Property FileName As String


    Public Function EquityURL(ByVal MyDates As Date) As String
        '' Status : In Production 09-08-2014 13.20
        '' This function takes in a date object and returns a url from which to download the file. 
        '' The target URL is of the format http://www.nseindia.com/content/historical/EQUITIES/<YYYY>/<MMM>/cm<dd><MMM><YYYY>bhav.csv.zip
        '' for eg : http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip is a bhav copy for 31/Jul/2014
        Dim MyMonthformat As String
        MyMonthformat = Format(MyDates, "MMM").ToUpper.ToString
        '''' http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip
        EquityURL = "http://www.nseindia.com/content/historical/EQUITIES/" & MyDates.Year.ToString & "/" & MyMonthformat & "/" & NSEEquityFileName(MyDates)
    End Function

    Public Function NSEEquityFileName(ByVal MyDates As Date) As String
        '' Status : In Production 09-08-2014 13.20
        '' This function takes in a date object and returns a NSEEquityFileName 
        '' that when embedded into NSEEquityURL function will be used to download NSE Bhav copies
        '' The target NSEEquityFileName is of the format cm<DD><MMM><YYYY>bhav.csv.zip
        Dim MyMonthformat, MyDayformat, MyYearformat As String
        MyYearformat = Format(MyDates, "yyyy").ToUpper.ToString
        MyMonthformat = Format(MyDates, "MMM").ToUpper.ToString
        MyDayformat = Format(MyDates, "dd").ToUpper.ToString
        NSEEquityFileName = "cm" & MyDayformat & MyMonthformat & MyYearformat & "bhav.csv.zip"
    End Function

    '' Headers to give the webclient
    ''GET /content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip HTTP/1.1
    ''--------------CLIENT-----------------------
    ''Accept: text/html, application/xhtml+xml, */*
    ''Accept-Language: en-IN
    ''User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko
    ''Accept-Encoding: gzip, deflate
    ''--------------CLIENT-----------------------
    ''--------------TRANSPORT--------------------
    ''Host: www.nseindia.com
    ''Connection: Keep-Alive
    ''--------------TRANSPORT--------------------
    ''--------------Cookies----------------------
    ''DNT: 1
    ''--------------Cookies----------------------


    '' Headers to give the webclient
    ''GET /content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip HTTP/1.1
    ''--------------CLIENT-----------------------
    ''Accept: text/html, application/xhtml+xml, */*
    ''Accept-Language: en-IN
    ''User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko
    ''Accept-Encoding: gzip, deflate
    ''--------------CLIENT-----------------------
    ''--------------TRANSPORT--------------------
    ''Host: www.nseindia.com
    ''Connection: Keep-Alive
    ''--------------TRANSPORT--------------------
    ''--------------Cookies----------------------
    ''DNT: 1
    ''--------------Cookies----------------------

    ''Derivatives http://www.bseindia.com/download/Bhavcopy/Derivative/bhavcopy18-08-14.zip
    '' Equities http://www.bseindia.com/download/BhavCopy/Equity/EQ180814_CSV.ZIP



    '' Traffic Details captured from DataDownloader 5-Jan-2015

    ''    #	Result	Protocol	Host	URL	Body	Caching	Content-Type	Process	Comments	Custom	
    ''6	200	HTTP	www.nseindia.com	/content/historical/EQUITIES/2015/JAN/cm05JAN2015bhav.csv.zip	57,998		application/zip	data downloader:8772			

    ''GET http://www.nseindia.com/content/historical/EQUITIES/2015/JAN/cm05JAN2015bhav.csv.zip HTTP/1.1
    ''User-Agent: Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/4.0.1
    ''Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8
    ''Accept-Language: en-us,en;q=0.5
    ''Accept-Encoding: gzip,deflate
    ''Accept-Charset: ISO-8859-1,utf-8;q=0.7,*;q=0.7
    ''Referer: http://www.nseindia.com/products/content/equities/equities/archieve_eq.htm
    ''Host: www.nseindia.com


    ''HTTP/1.1 200 OK
    ''Server: Oracle-iPlanet-Web-Server/7.0
    ''Content-Type: application/zip
    ''Last-Modified: Mon, 05 Jan 2015 11:08:07 GMT
    ''Content-Length: 57998
    ''ETag: &quot;e28e-54aa7097&quot;
    ''Accept-Ranges: bytes
    ''Date: Mon, 05 Jan 2015 15:51:08 GMT
    ''Connection: keep-alive






End Class
