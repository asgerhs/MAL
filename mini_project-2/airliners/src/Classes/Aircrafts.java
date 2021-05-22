package Classes;

public class Aircrafts {
    private String code, name, category;

    public Aircrafts(String code, String name, String category) {
        this.code = code;
        this.name = name;
        this.category = category;
    }

    public String getCode() {
        return code;
    }

    public String getName() {
        return name;
    }

    public String getCategory() {
        return category;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setCategory(String category) {
        this.category = category;
    }

    @Override
    public boolean equals(Object obj) {
        // TODO Auto-generated method stub
        return super.equals(obj);
    }

    @Override
    public int hashCode() {
        return Objects.hash(getCode(), getName(), getCategory());
    }

    @Override
    public String toString() {
        // TODO Auto-generated method stub
        return super.toString();
    }
    
}