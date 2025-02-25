//This is a cmocean colormap
//All credit to Kristen Thyng
//This colormap is under the MIT License
//All cmocean colormaps are available at https://github.com/matplotlib/cmocean/tree/master/cmocean/rgb

namespace ScottPlot.Colormaps;

public class Diff : IColormap
{
    public string Name => "Diff";
    readonly CustomPalette Colormap;
    public Color GetColor(double position) => Colormap.GetColor(position);

    public Diff()
    {
        Color[] colors =
        [
            new( 8, 35, 64 ),
            new( 9, 37, 66 ),
            new( 10, 38, 68 ),
            new( 11, 40, 69 ),
            new( 12, 42, 71 ),
            new( 12, 44, 73 ),
            new( 13, 45, 75 ),
            new( 14, 47, 77 ),
            new( 15, 49, 79 ),
            new( 16, 50, 81 ),
            new( 17, 52, 83 ),
            new( 17, 54, 85 ),
            new( 18, 55, 86 ),
            new( 19, 57, 88 ),
            new( 20, 59, 90 ),
            new( 20, 61, 92 ),
            new( 21, 62, 94 ),
            new( 22, 64, 95 ),
            new( 23, 66, 97 ),
            new( 24, 67, 99 ),
            new( 25, 69, 100 ),
            new( 26, 71, 102 ),
            new( 27, 72, 103 ),
            new( 29, 74, 104 ),
            new( 31, 76, 105 ),
            new( 33, 77, 106 ),
            new( 36, 79, 107 ),
            new( 38, 80, 108 ),
            new( 40, 82, 109 ),
            new( 43, 83, 110 ),
            new( 45, 85, 111 ),
            new( 47, 86, 112 ),
            new( 49, 88, 113 ),
            new( 52, 89, 115 ),
            new( 54, 91, 116 ),
            new( 56, 92, 117 ),
            new( 58, 94, 118 ),
            new( 60, 95, 119 ),
            new( 62, 97, 120 ),
            new( 65, 98, 121 ),
            new( 67, 100, 122 ),
            new( 69, 101, 123 ),
            new( 71, 103, 125 ),
            new( 73, 104, 126 ),
            new( 75, 106, 127 ),
            new( 77, 107, 128 ),
            new( 79, 109, 129 ),
            new( 81, 110, 130 ),
            new( 83, 112, 132 ),
            new( 85, 113, 133 ),
            new( 88, 115, 134 ),
            new( 90, 116, 135 ),
            new( 92, 118, 136 ),
            new( 94, 120, 138 ),
            new( 96, 121, 139 ),
            new( 98, 123, 140 ),
            new( 100, 124, 141 ),
            new( 102, 126, 142 ),
            new( 104, 127, 144 ),
            new( 106, 129, 145 ),
            new( 108, 130, 146 ),
            new( 110, 132, 148 ),
            new( 112, 134, 149 ),
            new( 114, 135, 150 ),
            new( 116, 137, 151 ),
            new( 118, 138, 153 ),
            new( 120, 140, 154 ),
            new( 123, 141, 155 ),
            new( 125, 143, 157 ),
            new( 127, 145, 158 ),
            new( 129, 146, 159 ),
            new( 131, 148, 161 ),
            new( 133, 150, 162 ),
            new( 135, 151, 163 ),
            new( 137, 153, 165 ),
            new( 139, 154, 166 ),
            new( 141, 156, 167 ),
            new( 143, 158, 169 ),
            new( 146, 159, 170 ),
            new( 148, 161, 172 ),
            new( 150, 163, 173 ),
            new( 152, 165, 175 ),
            new( 154, 166, 176 ),
            new( 156, 168, 177 ),
            new( 158, 170, 179 ),
            new( 160, 171, 180 ),
            new( 163, 173, 182 ),
            new( 165, 175, 183 ),
            new( 167, 177, 185 ),
            new( 169, 178, 186 ),
            new( 171, 180, 188 ),
            new( 174, 182, 189 ),
            new( 176, 184, 191 ),
            new( 178, 186, 192 ),
            new( 180, 187, 194 ),
            new( 182, 189, 196 ),
            new( 185, 191, 197 ),
            new( 187, 193, 199 ),
            new( 189, 195, 200 ),
            new( 191, 197, 202 ),
            new( 194, 198, 204 ),
            new( 196, 200, 205 ),
            new( 198, 202, 207 ),
            new( 200, 204, 209 ),
            new( 203, 206, 210 ),
            new( 205, 208, 212 ),
            new( 207, 210, 214 ),
            new( 210, 212, 215 ),
            new( 212, 214, 217 ),
            new( 214, 216, 219 ),
            new( 217, 218, 221 ),
            new( 219, 220, 222 ),
            new( 221, 222, 224 ),
            new( 224, 224, 226 ),
            new( 226, 226, 227 ),
            new( 228, 227, 229 ),
            new( 230, 229, 231 ),
            new( 232, 231, 232 ),
            new( 235, 233, 234 ),
            new( 236, 234, 235 ),
            new( 238, 236, 236 ),
            new( 240, 237, 238 ),
            new( 241, 238, 239 ),
            new( 243, 239, 239 ),
            new( 244, 240, 240 ),
            new( 245, 241, 240 ),
            new( 245, 241, 240 ),
            new( 246, 241, 240 ),
            new( 246, 241, 240 ),
            new( 245, 241, 239 ),
            new( 245, 240, 238 ),
            new( 244, 239, 237 ),
            new( 243, 238, 235 ),
            new( 242, 237, 233 ),
            new( 241, 235, 232 ),
            new( 239, 234, 229 ),
            new( 238, 232, 227 ),
            new( 236, 230, 225 ),
            new( 234, 229, 223 ),
            new( 232, 227, 220 ),
            new( 231, 225, 218 ),
            new( 229, 223, 215 ),
            new( 227, 221, 212 ),
            new( 225, 219, 210 ),
            new( 223, 217, 207 ),
            new( 221, 215, 205 ),
            new( 219, 213, 202 ),
            new( 217, 211, 199 ),
            new( 215, 209, 197 ),
            new( 213, 207, 194 ),
            new( 211, 205, 192 ),
            new( 210, 203, 189 ),
            new( 208, 201, 187 ),
            new( 206, 199, 184 ),
            new( 204, 197, 181 ),
            new( 202, 195, 179 ),
            new( 200, 193, 176 ),
            new( 199, 191, 174 ),
            new( 197, 189, 171 ),
            new( 195, 187, 169 ),
            new( 193, 185, 166 ),
            new( 191, 183, 164 ),
            new( 190, 181, 161 ),
            new( 188, 179, 159 ),
            new( 186, 177, 157 ),
            new( 185, 176, 154 ),
            new( 183, 174, 152 ),
            new( 181, 172, 149 ),
            new( 179, 170, 147 ),
            new( 178, 168, 144 ),
            new( 176, 166, 142 ),
            new( 174, 165, 140 ),
            new( 173, 163, 137 ),
            new( 171, 161, 135 ),
            new( 169, 159, 133 ),
            new( 168, 157, 130 ),
            new( 166, 156, 128 ),
            new( 164, 154, 125 ),
            new( 163, 152, 123 ),
            new( 161, 150, 121 ),
            new( 160, 149, 118 ),
            new( 158, 147, 116 ),
            new( 156, 145, 114 ),
            new( 155, 143, 112 ),
            new( 153, 142, 109 ),
            new( 152, 140, 107 ),
            new( 150, 138, 105 ),
            new( 149, 137, 103 ),
            new( 147, 135, 100 ),
            new( 145, 133, 98 ),
            new( 144, 132, 96 ),
            new( 142, 130, 94 ),
            new( 141, 128, 91 ),
            new( 139, 127, 89 ),
            new( 138, 125, 87 ),
            new( 136, 123, 85 ),
            new( 135, 122, 83 ),
            new( 133, 120, 80 ),
            new( 131, 118, 78 ),
            new( 130, 117, 76 ),
            new( 128, 115, 74 ),
            new( 127, 114, 72 ),
            new( 125, 112, 70 ),
            new( 124, 110, 67 ),
            new( 122, 109, 65 ),
            new( 121, 107, 63 ),
            new( 119, 106, 61 ),
            new( 118, 104, 59 ),
            new( 116, 102, 57 ),
            new( 114, 101, 55 ),
            new( 113, 99, 53 ),
            new( 111, 98, 51 ),
            new( 110, 96, 48 ),
            new( 108, 95, 46 ),
            new( 106, 93, 44 ),
            new( 104, 92, 43 ),
            new( 103, 90, 41 ),
            new( 101, 89, 39 ),
            new( 99, 88, 38 ),
            new( 97, 86, 37 ),
            new( 95, 85, 36 ),
            new( 93, 84, 35 ),
            new( 91, 82, 34 ),
            new( 89, 81, 33 ),
            new( 87, 79, 32 ),
            new( 85, 78, 32 ),
            new( 83, 77, 31 ),
            new( 81, 75, 30 ),
            new( 79, 74, 29 ),
            new( 77, 72, 29 ),
            new( 75, 71, 28 ),
            new( 73, 69, 27 ),
            new( 71, 68, 26 ),
            new( 69, 67, 26 ),
            new( 67, 65, 25 ),
            new( 66, 64, 24 ),
            new( 64, 62, 23 ),
            new( 62, 61, 22 ),
            new( 60, 59, 22 ),
            new( 58, 58, 21 ),
            new( 56, 57, 20 ),
            new( 54, 55, 19 ),
            new( 52, 54, 18 ),
            new( 51, 52, 18 ),
            new( 49, 51, 17 ),
            new( 47, 49, 16 ),
            new( 45, 48, 15 ),
            new( 43, 46, 14 ),
            new( 41, 45, 13 ),
            new( 39, 43, 12 ),
            new( 38, 42, 11 ),
            new( 36, 40, 10 ),
            new( 34, 39, 9 ),
            new( 32, 37, 9 ),
            new( 30, 36, 8 ),
            new( 28, 34, 7 ),
        ];

        Colormap = new CustomPalette(colors);
    }
}

