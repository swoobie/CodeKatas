namespace CodeKatas;

public class Tests {
    
[Test]
public void ContainsPythagoreanTriplet_ValidTriplet_ReturnsTrue() {
    int[] input = [3, 4, 5];
    var result = Katas.ContainsPythagoreanTriplet(input);
    Assert.That(result, Is.True);
}

[Test]
public void ContainsPythagoreanTriplet_NoTriplet_ReturnsFalse() {
    int[] input = [1, 2, 3];
    var result = Katas.ContainsPythagoreanTriplet(input);
    Assert.That(result, Is.False);
}

[Test]
public void ContainsPythagoreanTriplet_EmptyArray_ReturnsFalse() {
    int[] input = [];
    var result = Katas.ContainsPythagoreanTriplet(input);
    Assert.IsFalse(result);
}

[Test]
public void ContainsPythagoreanTriplet_LongTripletList_ReturnsTrue() {
    int[] input = [10, 6, 8, 10, 9, 12];
    var result = Katas.ContainsPythagoreanTriplet(input);
    Assert.That(result, Is.True);
}
    
}