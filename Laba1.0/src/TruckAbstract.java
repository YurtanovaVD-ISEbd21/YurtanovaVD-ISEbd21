import java.awt.Color;
import java.awt.Graphics;

public abstract class TruckAbstract implements ITransport {
	protected float _startPosX;// / Ëåâàÿ êîîðäèíàòà îòðèñîâêè àâòîìîáèëÿ
	protected float _startPosY;// / Ïðàâàÿ êîîðèäíàòà îòðèñîâêè àâòîìîáèëÿ
	protected int _pictureWidth; // / Øèðèíà îêíà îòðèñîâêè
	protected int _pictureHeight;// Âûñîòà îêíà îòðèñîâêè
	public int MaxSpeed; // Ìàêñèìàëüíàÿ ñêîðîñòü

	public int getMaxSpeed() {
		return MaxSpeed;
	}

	public void setMaxSpeed(int value) {
		MaxSpeed = value;
	}

	public float Weight;// Âåñ àâòîìîáèëÿ

	public float getWeight() {
		return Weight;
	}

	public void setWeight(float value) {
		Weight = value;
	}

	public Color MainColor;// Îñíîâíîé öâåò êóçîâà

	public Color getMainColor() {
		return MainColor;
	}

	public void setMainColor(Color value) {
		MainColor = value;
	}

	public void SetPosition(int x, int y, int width, int height) {
		_startPosX = x;
		_startPosY = y;
		_pictureWidth = width;
		_pictureHeight = height;
	}

	public abstract void DrawTruckTrailer(Graphics g);

	public abstract void MoveTransport(Direction direction);
}