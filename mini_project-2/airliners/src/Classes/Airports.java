package Classes;

public class Airports() {
    private String code, name, city, country, latitude, longitude;

    public Airports(String code, String name, String city, String country, String latitude, String longitude) {
        this.code = code;
        this.name = name;
        this.city = city;
        this.country = country;
        this.latitude = latitude;
        this.longitude = longitude;
    }

    public String getCode() {
        return code;
    }

    public String getName() {
        return name;
    }

    public String getCity() {
        return city;
    }

    public String getCountry(){
        return country;
    }

    public String getLatitude(){
        return latitude;
    }

    public String getLongitude(){
        return longitude;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    public void setLatitude(String latitude) {
        this.latitude = latitude;
    }

    public void setLongitude(String longitude) {
        this.longitude = longitude;
    }

    @Override
    public boolean equals(Object obj) {
        return super.equals(obj);
    }

    @Override
    public int hashCode() {
        return Objects.hash(getCode(), getName(), getCity(), getCountry(), getLatitude(), getLongitude());
    }

    @Override
    public String toString() {
        return "Airports{ code=";
    }

}