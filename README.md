# Testování třídy Class1 (MSTest)

Tento projekt obsahuje jednotkové testy (unit testy) pro třídu `Class1` napsané pomocí testovacího rozhraní **MSTest**.

---

## Přehled testovacích scénářů

1. **`IsCreated_DefaultValue_ReturnsFalse`**
   - **Cíl:** Ověřit, že výchozí hodnota vlastnosti `IsCreated` je `false` před voláním jakýchkoliv změn.
2. **`Create_WhenCalled_SetsIsCreatedToTrue`**
   - **Cíl:** Ověřit, že volání metody `Create()` změní hodnotu `IsCreated` na `true`.
3. **`GetList_WhenCalled_ReturnsExpectedSequence`**
   - **Cíl:** Ověřit, že metoda `GetList()` vrací očekávanou sekvenci čísel `[1, 2, 3, 4, 5]` v přesném pořadí.

---

## Jak testovat kolekce v MSTest: `CollectionAssert.AreEqual`

Při testování kolekcí v .NET nestačí použít běžný `Assert.AreEqual(expected, actual)`, protože ten u běžných tříd kolekcí (např. `List<T>`) porovnává **referenci na objekt**, nikoliv samotné prvky uvnitř kolekce.

K porovnání obsahu dvoch kolekcí slouží třída **`CollectionAssert`**, konkrétně metoda **`CollectionAssert.AreEqual`**.

### Jak `CollectionAssert.AreEqual` funguje:

1. **Porovnává prvky podle pořadí:** Test projde úspěšně pouze v případě, že obě kolekce mají:
   - Stejný počet prvků (délku/velikost).
   - Stejné prvky na **stejných indexech** (pořadí záleží).

2. **Porovnává jednotlivé prvky:** Metoda interně prochází prvky od indexu `0` a porovnává je přes `Equals()`.

---

### Případ užití a ukázka kódu

Chceme-li ověřit, že metoda `GetList()` vrací kolekci obsahující hodnoty `1` až `5`:

```csharp
[TestMethod]
public void GetList_WhenCalled_ReturnsExpectedSequence()
{
    // Arrange: Příprava očekávané kolekce prvků
    var expected = new List<int> { 1, 2, 3, 4, 5 };

    // Act: Zavolání testované metody
    var actual = MujObj.GetList();

    // Assert: Ověření obsahu kolekcí
    CollectionAssert.AreEqual(expected, actual);
}
