using System.ComponentModel.DataAnnotations;

namespace WebAppDBA.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}

-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQCbf15beQ5GWYvMbz8CdeZurK3MXLsKZfaAp9r07isoZNuyfvB0
yr7Nv9Jf+ue3cMfFHVn1rBZ7wRbEFyGcD0M2VmcIlpVbJnffyRgUSCMo59YjdagL
j+p374sPkjRkdC4j6pP61sVKQi4i9pppOT5lcRuQ4ibPh/UxrTyspAlKzwIDAQAB
AoGBAItRfNr8BTwmssiBy7SKqeDzOexmEPbqEAeJXPYiBez1IJo2fX5GwNlbSkPQ
a5fBplsHRziD7MkIYTtjdit6yT4RzP9hFBlGbYEBwXNrVftmOND/fPl+3wTGtG1r
rsO6T3j1w18o0PUNiZ9q+fRn18p+oyAltf3oE07k4MNRnIOBAkEA+JS9xMwUGhIO
AxmyCoKK/5u5xwVZADwZZ6vOU2YbgZEpgUdx6LGdC3a01XSDiNnOK+cSbJk4KzjP
hWTtMmRwrwJBAKAjbp87Zg/Y6ZcJUmBTUpy01wroK9xiteBqMW+nBeFX02ugK2/p
bjZP/l4BUi4B215uwVXQH7GOJcwmA7VYD+ECQCmGj30EqocAZR7XeAqRbC7vEMXS
et+zKntLFBiSgh3O5iQWj0zT/uwfVG4kHKUL3Ykv/L/viJaP0vrxtT4p0TkCQG3l
QvI1gioX8t36wLRoGgZ+uCC9CfSZLTWPytNTrN5jNizi40xOxpqxNN/wSiRWk+Pv
X/By/n0MDvZVlC/r+iECQQCRWCfZyfvFsupQk4eKk3m4J5vFwdRhzuqdWHCBW90L
gvevyB9oPHNIzYn5oOM/owHbAmfZvZZesGKxcLvJof5+
-----END RSA PRIVATE KEY-----

-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCbf15beQ5GWYvMbz8CdeZurK3M
XLsKZfaAp9r07isoZNuyfvB0yr7Nv9Jf+ue3cMfFHVn1rBZ7wRbEFyGcD0M2VmcI
lpVbJnffyRgUSCMo59YjdagLj+p374sPkjRkdC4j6pP61sVKQi4i9pppOT5lcRuQ
4ibPh/UxrTyspAlKzwIDAQAB
-----END PUBLIC KEY-----