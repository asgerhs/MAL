package Classes;

public class Airlines {
    private String code, name, country;
    
    public Airlines(String code, String name, String country) {
        this.code = code;
        this.name = name;
        this.country = country;
    }


    public String getCode() {
        return this.code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCountry() {
        return this.country;
    }

    public void setCountry(String country) {
        this.country = country;
    }    

}
