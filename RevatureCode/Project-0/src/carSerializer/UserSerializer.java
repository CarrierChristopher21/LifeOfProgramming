package carSerializer;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.List;

import carUser.UserData;

public class UserSerializer implements UserDataAccessor{
	public  Object readObject(String filename) {
		try(ObjectInputStream ois = new ObjectInputStream(
				new FileInputStream(filename))){
			Object obj = ois.readObject();
			System.out.println(obj);
			return obj;
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		}
	}
	
	public  void writeObject(String filename, Object o) {
		try(ObjectOutputStream oos = new ObjectOutputStream(
				new FileOutputStream(filename))){
			
			oos.writeObject(o);
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	@SuppressWarnings("unchecked")
	public  Object readObjectList(String filename) {
		try(ObjectInputStream ois = new ObjectInputStream(
				new FileInputStream(filename))){
			List<UserData> obj = (List<UserData>)ois.readObject();
			System.out.println(obj);
			return obj;
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		}
	}
	
	public  void writeObjectList(String filename, List<Object> o) {
		try(ObjectOutputStream oos = new ObjectOutputStream(
				new FileOutputStream(filename))){
			
			oos.writeObject(o);
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
