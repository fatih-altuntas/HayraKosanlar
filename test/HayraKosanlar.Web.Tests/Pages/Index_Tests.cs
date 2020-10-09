using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HayraKosanlar.Pages
{
    public class Index_Tests : HayraKosanlarWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
