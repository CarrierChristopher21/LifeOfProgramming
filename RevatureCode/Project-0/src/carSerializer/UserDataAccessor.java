package carSerializer;

import java.util.List;

public interface UserDataAccessor {
	Object readObject(String filename);
	Object readObjectList(String filename);
	void writeObject(String filename, Object o);
	void writeObjectList(String filename, List<Object> l);
}
