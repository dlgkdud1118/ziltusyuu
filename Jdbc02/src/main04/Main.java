package main04;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class Main{
	
	public static void main(String[] args) {
		
		String url = "jdbc:mysql://localhost:3306/pc_shop_db";
		String user = "shop_user";
		String password = "pass";
		
		String sql = "INSERT INTO m user						"
					+ "(user_id, user_name, email, birth_day)	"
					+ "VALUES									"
					+
	}
}