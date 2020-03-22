package Jv2_02;

import java.util.ArrayList;

public class MovieList {
    private ArrayList<String> movieList = new ArrayList<>();
    public static void  main(String[] args){
        System.out.println(" Cac bo phim yeu thich");
        System.out.println("-----------------------");
        MovieList list = new MovieList();
        list.addMovie("Quỳnh búp bê");
        list.addMovie("Người phán xử");
        list.addMovie("Về nhà đi  con");
        list.addMovie("7 viên ngọc  rồng");


        list.displayList();
    }
    public void addMovie(String movie){
        movieList.add(movie);
    }
    public void displayList(){
        System.out.println("You have" + movieList.size() + "item in favorite list");
        for (int i=0;i<movieList.size();i++){
            System.out.println("Movie" + (i+1) +""+movieList.get(i));
        }
    }
    public void updateMovie(int index,String movie){
        movieList.set(index,movie);
        System.out.println("Updated");
        System.out.println("<Moive"+(index+1)+""+movie);
    }
    public void removeMovie(int index){
        String movie= movieList.get(index);
        movieList.remove(index);
        System.out.println("Removed"+movie);
    }
    public String findMovie(String search){
        int position=movieList.indexOf(search);
        if (position>0) {
            return movieList.get(position);
        }
        return search;
    }
}
