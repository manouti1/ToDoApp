using Entities.Models;
using Xunit;

namespace ToDoApi.Tests.UnitTests.Models
{
    public class ToDoItemTest
    {
        private readonly ToDoItem _ToDoItem;

        public ToDoItemTest()
        {
            _ToDoItem = new ToDoItem();
        }

        [Fact]
        public void ReturnFalseGivenNameNull()
        {
            var result = _ToDoItem.CheckValidName();
            Assert.False(result, "Name should not be null");
        }

        [Fact]
        public void ReturnFalseGivenNameEmpty()
        {
            _ToDoItem.Name = "";
            var result = _ToDoItem.CheckValidName();
            Assert.False(result, "Name should not be empty");
        }

        [Fact]
        public void ReturnFalseGivenNameWhitSpace()
        {
            _ToDoItem.Name = "    ";
            var result = _ToDoItem.CheckValidName();
            Assert.False(result, "Name should not be whit space");
        }

        [Fact]
        public void ReturnFalseGivenNameLengthMoreThan10()
        {
            _ToDoItem.Name = ".Net Core Unit Test";
            var result = _ToDoItem.CheckValidName();
            Assert.False(result, "Name should not be more than 10");
        }

        [Fact]
        public void ReturnFalseGivenNameNotEn()
        {
            _ToDoItem.Name = ".เนต คอ";
            var result = _ToDoItem.CheckValidName();
            Assert.False(result, "Name should be English");
        }

        [Fact]
        public void ReturnTrueGivenNameEnAndLessThan10()
        {
            _ToDoItem.Name = "Teera Nai";
            var result = _ToDoItem.CheckValidName();
            Assert.True(result, "Name should be English and less than 10");
        }
    }
}
